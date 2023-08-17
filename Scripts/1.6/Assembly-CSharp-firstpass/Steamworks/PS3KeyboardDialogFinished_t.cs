using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(710)]
public struct PS3KeyboardDialogFinished_t
{
	public const int k_iCallback = 710;
}
