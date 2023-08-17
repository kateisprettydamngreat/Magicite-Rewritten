using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(707)]
public struct NetStartDialogUnloaded_t
{
	public const int k_iCallback = 707;
}
