using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(1101)]
public struct UserStatsReceived_t
{
	public const int k_iCallback = 1101;

	public ulong m_nGameID;

	public EResult m_eResult;

	public CSteamID m_steamIDUser;
}
