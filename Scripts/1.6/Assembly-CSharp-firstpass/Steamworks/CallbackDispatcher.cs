using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Steamworks;

public class CallbackDispatcher
{
	private static Dictionary<int, ICallbackBase> m_RegisteredCallbacks = new Dictionary<int, ICallbackBase>();

	private static Dictionary<SteamAPICall_t, ICallResultBase> m_RegisteredCallResults = new Dictionary<SteamAPICall_t, ICallResultBase>();

	public static Callback<SteamAPICallCompleted_t> m_APICallbackCompleted = new Callback<SteamAPICallCompleted_t>(RunCallResult);

	public static HSteamPipe m_LastActivePipe { get; private set; }

	public static void RegisterCallback(ICallbackBase callback, int iCallback)
	{
		try
		{
			m_RegisteredCallbacks.Add(iCallback, callback);
		}
		catch (ArgumentException ex)
		{
			throw new Exception("You tried to register a specific Callback multiple times.\nIf you need a callback to end up in multiple places then register it once and delegate it elsewhere from there.\n" + ex);
		}
	}

	public static void UnRegisterCallback(ICallbackBase callback, int iCallback)
	{
		if (m_RegisteredCallbacks[iCallback] == callback)
		{
			m_RegisteredCallbacks.Remove(iCallback);
		}
	}

	public static void RegisterCallResult(ICallResultBase callback, SteamAPICall_t hAPICall)
	{
		try
		{
			m_RegisteredCallResults.Add(hAPICall, callback);
		}
		catch (ArgumentException ex)
		{
			throw new Exception("You tried to register a CallResult multiple times.\nIf you need a callresult to end up in multiple places then register it once and delegate it elsewhere from there.\n" + ex);
		}
	}

	public static void UnregisterCallResult(ICallResultBase callback, SteamAPICall_t hAPICall)
	{
		if (m_RegisteredCallResults[hAPICall] == callback)
		{
			m_RegisteredCallResults.Remove(hAPICall);
		}
	}

	public static void RunCallbacks()
	{
		HSteamPipe hSteamPipe = SteamAPI.GetHSteamPipe();
		CallbackMsg_t pCallbackMsg;
		while (NativeMethods.Steam_BGetCallback(hSteamPipe, out pCallbackMsg))
		{
			m_LastActivePipe = hSteamPipe;
			if (m_RegisteredCallbacks.TryGetValue(pCallbackMsg.m_iCallback, out var value))
			{
				value.Run(pCallbackMsg.m_pubParam);
			}
			NativeMethods.Steam_FreeLastCallback(hSteamPipe);
		}
		SteamUtils.RunFrame();
		SteamController.RunFrame();
	}

	public static void RunCallResult(SteamAPICallCompleted_t apicall)
	{
		if (!m_RegisteredCallResults.TryGetValue(apicall.m_hAsyncCall, out var value))
		{
			return;
		}
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = Marshal.AllocHGlobal(value.GetCallbackSizeBytes());
			if (NativeMethods.Steam_GetAPICallResult(m_LastActivePipe, apicall.m_hAsyncCall, intPtr, value.GetCallbackSizeBytes(), value.GetICallback(), out var pbFailed))
			{
				value.Run(intPtr, pbFailed);
			}
		}
		finally
		{
			UnregisterCallResult(value, apicall.m_hAsyncCall);
			Marshal.FreeHGlobal(intPtr);
		}
	}
}
