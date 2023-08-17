using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(1201)]
public struct SocketStatusCallback_t
{
	public const int k_iCallback = 1201;

	public SNetSocket_t m_hSocket;

	public SNetListenSocket_t m_hListenSocket;

	public CSteamID m_steamIDRemote;

	public int m_eSNetSocketState;
}
