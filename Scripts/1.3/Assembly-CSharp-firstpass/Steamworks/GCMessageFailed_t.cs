using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(1702)]
public struct GCMessageFailed_t
{
	public const int k_iCallback = 1702;
}
