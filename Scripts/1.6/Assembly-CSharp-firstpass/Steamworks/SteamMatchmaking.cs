using System;
using System.Runtime.InteropServices;

namespace Steamworks;

public static class SteamMatchmaking
{
	public static int GetFavoriteGameCount()
	{
		return NativeMethods.ISteamMatchmaking_GetFavoriteGameCount();
	}

	public static bool GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer)
	{
		return NativeMethods.ISteamMatchmaking_GetFavoriteGame(iGame, out pnAppID, out pnIP, out pnConnPort, out pnQueryPort, out punFlags, out pRTime32LastPlayedOnServer);
	}

	public static bool RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags)
	{
		return NativeMethods.ISteamMatchmaking_RemoveFavoriteGame(nAppID, nIP, nConnPort, nQueryPort, unFlags);
	}

	public static SteamAPICall_t RequestLobbyList()
	{
		return NativeMethods.ISteamMatchmaking_RequestLobbyList();
	}

	public static void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType)
	{
		NativeMethods.ISteamMatchmaking_AddRequestLobbyListStringFilter(new InteropHelp.UTF8String(pchKeyToMatch), new InteropHelp.UTF8String(pchValueToMatch), eComparisonType);
	}

	public static void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType)
	{
		NativeMethods.ISteamMatchmaking_AddRequestLobbyListNumericalFilter(new InteropHelp.UTF8String(pchKeyToMatch), nValueToMatch, eComparisonType);
	}

	public static void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo)
	{
		NativeMethods.ISteamMatchmaking_AddRequestLobbyListNearValueFilter(new InteropHelp.UTF8String(pchKeyToMatch), nValueToBeCloseTo);
	}

	public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable)
	{
		NativeMethods.ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(nSlotsAvailable);
	}

	public static void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter)
	{
		NativeMethods.ISteamMatchmaking_AddRequestLobbyListDistanceFilter(eLobbyDistanceFilter);
	}

	public static void AddRequestLobbyListResultCountFilter(int cMaxResults)
	{
		NativeMethods.ISteamMatchmaking_AddRequestLobbyListResultCountFilter(cMaxResults);
	}

	public static void AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby)
	{
		NativeMethods.ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(steamIDLobby);
	}

	public static CSteamID GetLobbyByIndex(int iLobby)
	{
		return NativeMethods.ISteamMatchmaking_GetLobbyByIndex(iLobby);
	}

	public static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers)
	{
		return NativeMethods.ISteamMatchmaking_CreateLobby(eLobbyType, cMaxMembers);
	}

	public static SteamAPICall_t JoinLobby(CSteamID steamIDLobby)
	{
		return NativeMethods.ISteamMatchmaking_JoinLobby(steamIDLobby);
	}

	public static void LeaveLobby(CSteamID steamIDLobby)
	{
		NativeMethods.ISteamMatchmaking_LeaveLobby(steamIDLobby);
	}

	public static bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee)
	{
		return NativeMethods.ISteamMatchmaking_InviteUserToLobby(steamIDLobby, steamIDInvitee);
	}

	public static int GetNumLobbyMembers(CSteamID steamIDLobby)
	{
		return NativeMethods.ISteamMatchmaking_GetNumLobbyMembers(steamIDLobby);
	}

	public static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember)
	{
		return NativeMethods.ISteamMatchmaking_GetLobbyMemberByIndex(steamIDLobby, iMember);
	}

	public static string GetLobbyData(CSteamID steamIDLobby, string pchKey)
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamMatchmaking_GetLobbyData(steamIDLobby, new InteropHelp.UTF8String(pchKey)));
	}

	public static bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue)
	{
		return NativeMethods.ISteamMatchmaking_SetLobbyData(steamIDLobby, new InteropHelp.UTF8String(pchKey), new InteropHelp.UTF8String(pchValue));
	}

	public static int GetLobbyDataCount(CSteamID steamIDLobby)
	{
		return NativeMethods.ISteamMatchmaking_GetLobbyDataCount(steamIDLobby);
	}

	public static bool GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, out string pchKey, int cchKeyBufferSize, out string pchValue, int cchValueBufferSize)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(cchKeyBufferSize);
		IntPtr intPtr2 = Marshal.AllocHGlobal(cchValueBufferSize);
		bool flag = NativeMethods.ISteamMatchmaking_GetLobbyDataByIndex(steamIDLobby, iLobbyData, intPtr, cchKeyBufferSize, intPtr2, cchValueBufferSize);
		pchKey = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr));
		pchValue = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr2));
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return flag;
	}

	public static bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey)
	{
		return NativeMethods.ISteamMatchmaking_DeleteLobbyData(steamIDLobby, new InteropHelp.UTF8String(pchKey));
	}

	public static string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey)
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamMatchmaking_GetLobbyMemberData(steamIDLobby, steamIDUser, new InteropHelp.UTF8String(pchKey)));
	}

	public static void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue)
	{
		NativeMethods.ISteamMatchmaking_SetLobbyMemberData(steamIDLobby, new InteropHelp.UTF8String(pchKey), new InteropHelp.UTF8String(pchValue));
	}

	public static bool SendLobbyChatMsg(CSteamID steamIDLobby, IntPtr pvMsgBody, int cubMsgBody)
	{
		return NativeMethods.ISteamMatchmaking_SendLobbyChatMsg(steamIDLobby, pvMsgBody, cubMsgBody);
	}

	public static int GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType)
	{
		return NativeMethods.ISteamMatchmaking_GetLobbyChatEntry(steamIDLobby, iChatID, out pSteamIDUser, pvData, cubData, out peChatEntryType);
	}

	public static bool RequestLobbyData(CSteamID steamIDLobby)
	{
		return NativeMethods.ISteamMatchmaking_RequestLobbyData(steamIDLobby);
	}

	public static void SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer)
	{
		NativeMethods.ISteamMatchmaking_SetLobbyGameServer(steamIDLobby, unGameServerIP, unGameServerPort, steamIDGameServer);
	}

	public static bool GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer)
	{
		return NativeMethods.ISteamMatchmaking_GetLobbyGameServer(steamIDLobby, out punGameServerIP, out punGameServerPort, out psteamIDGameServer);
	}

	public static bool SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers)
	{
		return NativeMethods.ISteamMatchmaking_SetLobbyMemberLimit(steamIDLobby, cMaxMembers);
	}

	public static int GetLobbyMemberLimit(CSteamID steamIDLobby)
	{
		return NativeMethods.ISteamMatchmaking_GetLobbyMemberLimit(steamIDLobby);
	}

	public static bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType)
	{
		return NativeMethods.ISteamMatchmaking_SetLobbyType(steamIDLobby, eLobbyType);
	}

	public static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable)
	{
		return NativeMethods.ISteamMatchmaking_SetLobbyJoinable(steamIDLobby, bLobbyJoinable);
	}

	public static CSteamID GetLobbyOwner(CSteamID steamIDLobby)
	{
		return NativeMethods.ISteamMatchmaking_GetLobbyOwner(steamIDLobby);
	}

	public static bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner)
	{
		return NativeMethods.ISteamMatchmaking_SetLobbyOwner(steamIDLobby, steamIDNewOwner);
	}

	public static bool SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent)
	{
		return NativeMethods.ISteamMatchmaking_SetLinkedLobby(steamIDLobby, steamIDLobbyDependent);
	}
}
