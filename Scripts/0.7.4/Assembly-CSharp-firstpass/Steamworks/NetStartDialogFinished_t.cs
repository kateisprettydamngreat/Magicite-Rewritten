using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(706)]
public struct NetStartDialogFinished_t
{
	public const int k_iCallback = 706;
}
