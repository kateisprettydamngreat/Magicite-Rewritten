namespace Steamworks;

public static class GameServer
{
	public static bool InitSafe(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString)
	{
		return NativeMethods.SteamGameServer_InitSafe(unIP, usSteamPort, usGamePort, usQueryPort, eServerMode, new InteropHelp.UTF8String(pchVersionString));
	}

	public static bool Init(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString)
	{
		return NativeMethods.SteamGameServer_InitSafe(unIP, usSteamPort, usGamePort, usQueryPort, eServerMode, new InteropHelp.UTF8String(pchVersionString));
	}

	public static void Shutdown()
	{
		NativeMethods.SteamGameServer_Shutdown();
	}

	public static bool BSecure()
	{
		return NativeMethods.SteamGameServer_BSecure();
	}

	public static CSteamID GetSteamID()
	{
		return NativeMethods.SteamGameServer_GetSteamID();
	}

	public static HSteamPipe GetHSteamPipe()
	{
		return NativeMethods.SteamGameServer_GetHSteamPipe();
	}

	public static HSteamUser GetHSteamUser()
	{
		return NativeMethods.SteamGameServer_GetHSteamUser();
	}
}
