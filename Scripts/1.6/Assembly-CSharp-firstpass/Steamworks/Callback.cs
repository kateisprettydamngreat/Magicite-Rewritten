using System;
using System.Runtime.InteropServices;

namespace Steamworks;

public class Callback<T> : ICallbackBase
{
	public delegate void DispatchDelegate(T param);

	public event DispatchDelegate m_Func;

	public Callback()
	{
		CallbackDispatcher.RegisterCallback(this, CallbackIdentities.GetCallbackIdentity(typeof(T)));
	}

	public Callback(DispatchDelegate myFunc)
		: this()
	{
		if (myFunc == null)
		{
			throw new Exception("Function must not be null.");
		}
		this.m_Func = (DispatchDelegate)Delegate.Combine(this.m_Func, myFunc);
	}

	~Callback()
	{
		UnRegister();
	}

	public void UnRegister()
	{
		CallbackDispatcher.UnRegisterCallback(this, CallbackIdentities.GetCallbackIdentity(typeof(T)));
	}

	public void Run(IntPtr pubParam)
	{
		this.m_Func((T)Marshal.PtrToStructure(pubParam, typeof(T)));
	}
}
