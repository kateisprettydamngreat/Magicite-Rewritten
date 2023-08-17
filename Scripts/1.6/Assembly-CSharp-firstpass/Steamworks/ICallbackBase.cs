using System;

namespace Steamworks;

public interface ICallbackBase
{
	void Run(IntPtr param);
}
