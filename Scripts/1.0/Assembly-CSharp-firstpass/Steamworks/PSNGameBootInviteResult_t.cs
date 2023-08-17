using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(515)]
public struct PSNGameBootInviteResult_t
{
	public const int k_iCallback = 515;

	[MarshalAs(UnmanagedType.I1)]
	public bool m_bGameBootInviteExists;

	public CSteamID m_steamIDLobby;
}
