using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(101)]
public struct SteamServersConnected_t
{
	public const int k_iCallback = 101;
}
