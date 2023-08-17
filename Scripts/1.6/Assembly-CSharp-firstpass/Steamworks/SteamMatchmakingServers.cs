using System;

namespace Steamworks;

public static class SteamMatchmakingServers
{
	public static HServerListRequest RequestInternetServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
	{
		return NativeMethods.ISteamMatchmakingServers_RequestInternetServerList(iApp, ppchFilters, nFilters, pRequestServersResponse);
	}

	public static HServerListRequest RequestLANServerList(AppId_t iApp, IntPtr pRequestServersResponse)
	{
		return NativeMethods.ISteamMatchmakingServers_RequestLANServerList(iApp, pRequestServersResponse);
	}

	public static HServerListRequest RequestFriendsServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
	{
		return NativeMethods.ISteamMatchmakingServers_RequestFriendsServerList(iApp, ppchFilters, nFilters, pRequestServersResponse);
	}

	public static HServerListRequest RequestFavoritesServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
	{
		return NativeMethods.ISteamMatchmakingServers_RequestFavoritesServerList(iApp, ppchFilters, nFilters, pRequestServersResponse);
	}

	public static HServerListRequest RequestHistoryServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
	{
		return NativeMethods.ISteamMatchmakingServers_RequestHistoryServerList(iApp, ppchFilters, nFilters, pRequestServersResponse);
	}

	public static HServerListRequest RequestSpectatorServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
	{
		return NativeMethods.ISteamMatchmakingServers_RequestSpectatorServerList(iApp, ppchFilters, nFilters, pRequestServersResponse);
	}

	public static void ReleaseRequest(HServerListRequest hServerListRequest)
	{
		NativeMethods.ISteamMatchmakingServers_ReleaseRequest(hServerListRequest);
	}

	public static IntPtr GetServerDetails(HServerListRequest hRequest, int iServer)
	{
		return NativeMethods.ISteamMatchmakingServers_GetServerDetails(hRequest, iServer);
	}

	public static void CancelQuery(HServerListRequest hRequest)
	{
		NativeMethods.ISteamMatchmakingServers_CancelQuery(hRequest);
	}

	public static void RefreshQuery(HServerListRequest hRequest)
	{
		NativeMethods.ISteamMatchmakingServers_RefreshQuery(hRequest);
	}

	public static bool IsRefreshing(HServerListRequest hRequest)
	{
		return NativeMethods.ISteamMatchmakingServers_IsRefreshing(hRequest);
	}

	public static int GetServerCount(HServerListRequest hRequest)
	{
		return NativeMethods.ISteamMatchmakingServers_GetServerCount(hRequest);
	}

	public static void RefreshServer(HServerListRequest hRequest, int iServer)
	{
		NativeMethods.ISteamMatchmakingServers_RefreshServer(hRequest, iServer);
	}

	public static HServerQuery PingServer(uint unIP, ushort usPort, IntPtr pRequestServersResponse)
	{
		return NativeMethods.ISteamMatchmakingServers_PingServer(unIP, usPort, pRequestServersResponse);
	}

	public static HServerQuery PlayerDetails(uint unIP, ushort usPort, IntPtr pRequestServersResponse)
	{
		return NativeMethods.ISteamMatchmakingServers_PlayerDetails(unIP, usPort, pRequestServersResponse);
	}

	public static HServerQuery ServerRules(uint unIP, ushort usPort, IntPtr pRequestServersResponse)
	{
		return NativeMethods.ISteamMatchmakingServers_ServerRules(unIP, usPort, pRequestServersResponse);
	}

	public static void CancelServerQuery(HServerQuery hServerQuery)
	{
		NativeMethods.ISteamMatchmakingServers_CancelServerQuery(hServerQuery);
	}
}
