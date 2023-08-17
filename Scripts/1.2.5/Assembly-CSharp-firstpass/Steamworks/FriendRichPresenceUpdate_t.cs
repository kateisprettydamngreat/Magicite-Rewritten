using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(336)]
public struct FriendRichPresenceUpdate_t
{
	public const int k_iCallback = 336;

	public CSteamID m_steamIDFriend;

	public AppId_t m_nAppID;
}
