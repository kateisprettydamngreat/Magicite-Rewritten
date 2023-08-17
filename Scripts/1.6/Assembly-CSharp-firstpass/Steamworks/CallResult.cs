using System;
using System.Runtime.InteropServices;

namespace Steamworks;

public class CallResult<T> : ICallResultBase
{
	public delegate void APIDispatchDelegate(T param, bool bIOFailure);

	private SteamAPICall_t m_hAPICall = SteamAPICall_t.Invalid;

	private int m_iCallback;

	private int m_Size;

	public event APIDispatchDelegate m_Func;

	public CallResult()
	{
		m_iCallback = CallbackIdentities.GetCallbackIdentity(typeof(T));
		m_Size = Marshal.SizeOf(typeof(T));
	}

	public CallResult(APIDispatchDelegate myFunc)
		: this()
	{
		if (myFunc == null)
		{
			throw new Exception("Function must not be null.");
		}
		this.m_Func = (APIDispatchDelegate)Delegate.Combine(this.m_Func, myFunc);
	}

	public CallResult(APIDispatchDelegate myFunc, SteamAPICall_t hAPICall)
		: this(myFunc)
	{
		Set(hAPICall);
	}

	~CallResult()
	{
		Cancel();
	}

	public void Set(SteamAPICall_t hAPICall)
	{
		if (m_hAPICall != SteamAPICall_t.Invalid)
		{
			Cancel();
		}
		m_hAPICall = hAPICall;
		if (hAPICall != SteamAPICall_t.Invalid)
		{
			CallbackDispatcher.RegisterCallResult(this, hAPICall);
		}
	}

	public bool IsActive()
	{
		return m_hAPICall != SteamAPICall_t.Invalid;
	}

	public void Cancel()
	{
		if (m_hAPICall != SteamAPICall_t.Invalid)
		{
			CallbackDispatcher.UnregisterCallResult(this, m_hAPICall);
			m_hAPICall = SteamAPICall_t.Invalid;
		}
	}

	public int GetCallbackSizeBytes()
	{
		return m_Size;
	}

	public int GetICallback()
	{
		return m_iCallback;
	}

	public void Run(IntPtr pubParam, bool bIOFailure)
	{
		m_hAPICall = SteamAPICall_t.Invalid;
		this.m_Func((T)Marshal.PtrToStructure(pubParam, typeof(T)), bIOFailure);
	}
}
