using System;

namespace Steamworks;

public interface ICallResultBase
{
	int GetCallbackSizeBytes();

	int GetICallback();

	void Run(IntPtr param, bool bIOFailure);
}
