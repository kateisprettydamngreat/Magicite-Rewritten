using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(708)]
public struct PS3SystemMenuClosed_t
{
	public const int k_iCallback = 708;
}
