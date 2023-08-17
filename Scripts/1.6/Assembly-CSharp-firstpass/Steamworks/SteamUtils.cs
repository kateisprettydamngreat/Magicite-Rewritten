using System;
using System.Runtime.InteropServices;

namespace Steamworks;

public static class SteamUtils
{
	public static uint GetSecondsSinceAppActive()
	{
		return NativeMethods.ISteamUtils_GetSecondsSinceAppActive();
	}

	public static uint GetSecondsSinceComputerActive()
	{
		return NativeMethods.ISteamUtils_GetSecondsSinceComputerActive();
	}

	public static EUniverse GetConnectedUniverse()
	{
		return NativeMethods.ISteamUtils_GetConnectedUniverse();
	}

	public static uint GetServerRealTime()
	{
		return NativeMethods.ISteamUtils_GetServerRealTime();
	}

	public static string GetIPCountry()
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUtils_GetIPCountry());
	}

	public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
	{
		return NativeMethods.ISteamUtils_GetImageSize(iImage, out pnWidth, out pnHeight);
	}

	public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
	{
		return NativeMethods.ISteamUtils_GetImageRGBA(iImage, pubDest, nDestBufferSize);
	}

	public static bool GetCSERIPPort(out uint unIP, out ushort usPort)
	{
		return NativeMethods.ISteamUtils_GetCSERIPPort(out unIP, out usPort);
	}

	public static byte GetCurrentBatteryPower()
	{
		return NativeMethods.ISteamUtils_GetCurrentBatteryPower();
	}

	public static AppId_t GetAppID()
	{
		return NativeMethods.ISteamUtils_GetAppID();
	}

	public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
	{
		NativeMethods.ISteamUtils_SetOverlayNotificationPosition(eNotificationPosition);
	}

	public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
	{
		return NativeMethods.ISteamUtils_IsAPICallCompleted(hSteamAPICall, out pbFailed);
	}

	public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
	{
		return NativeMethods.ISteamUtils_GetAPICallFailureReason(hSteamAPICall);
	}

	public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
	{
		return NativeMethods.ISteamUtils_GetAPICallResult(hSteamAPICall, pCallback, cubCallback, iCallbackExpected, out pbFailed);
	}

	public static void RunFrame()
	{
		NativeMethods.ISteamUtils_RunFrame();
	}

	public static uint GetIPCCallCount()
	{
		return NativeMethods.ISteamUtils_GetIPCCallCount();
	}

	public static void SetWarningMessageHook(IntPtr pFunction)
	{
		NativeMethods.ISteamUtils_SetWarningMessageHook(pFunction);
	}

	public static bool IsOverlayEnabled()
	{
		return NativeMethods.ISteamUtils_IsOverlayEnabled();
	}

	public static bool BOverlayNeedsPresent()
	{
		return NativeMethods.ISteamUtils_BOverlayNeedsPresent();
	}

	public static SteamAPICall_t CheckFileSignature(string szFileName)
	{
		return NativeMethods.ISteamUtils_CheckFileSignature(new InteropHelp.UTF8String(szFileName));
	}

	public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax)
	{
		return NativeMethods.ISteamUtils_ShowGamepadTextInput(eInputMode, eLineInputMode, new InteropHelp.UTF8String(pchDescription), unCharMax);
	}

	public static uint GetEnteredGamepadTextLength()
	{
		return NativeMethods.ISteamUtils_GetEnteredGamepadTextLength();
	}

	public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
	{
		IntPtr intPtr = Marshal.AllocHGlobal((int)cchText);
		bool flag = NativeMethods.ISteamUtils_GetEnteredGamepadTextInput(intPtr, cchText);
		pchText = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr));
		Marshal.FreeHGlobal(intPtr);
		return flag;
	}

	public static string GetSteamUILanguage()
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUtils_GetSteamUILanguage());
	}

	public static bool IsSteamRunningInVR()
	{
		return NativeMethods.ISteamUtils_IsSteamRunningInVR();
	}
}
