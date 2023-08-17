namespace Steamworks;

public static class SteamAPI
{
	public static bool RestartAppIfNecessary(AppId_t unOwnAppID)
	{
		return NativeMethods.SteamAPI_RestartAppIfNecessary(unOwnAppID);
	}

	public static bool InitSafe()
	{
		return NativeMethods.SteamAPI_InitSafe();
	}

	public static bool Init()
	{
		return NativeMethods.SteamAPI_InitSafe();
	}

	public static void Shutdown()
	{
		NativeMethods.SteamAPI_Shutdown();
	}

	public static void RunCallbacks()
	{
		CallbackDispatcher.RunCallbacks();
	}

	public static bool IsSteamRunning()
	{
		return NativeMethods.SteamAPI_IsSteamRunning();
	}

	public static HSteamUser GetHSteamUserCurrent()
	{
		return NativeMethods.Steam_GetHSteamUserCurrent();
	}

	public static HSteamPipe GetHSteamPipe()
	{
		return NativeMethods.SteamAPI_GetHSteamPipe();
	}

	public static HSteamUser GetHSteamUser()
	{
		return NativeMethods.SteamAPI_GetHSteamUser();
	}
}
