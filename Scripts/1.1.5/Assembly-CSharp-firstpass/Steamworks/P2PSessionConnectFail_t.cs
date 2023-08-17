using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(1203)]
public struct P2PSessionConnectFail_t
{
	public const int k_iCallback = 1203;

	public CSteamID m_steamIDRemote;

	public byte m_eP2PSessionError;
}
