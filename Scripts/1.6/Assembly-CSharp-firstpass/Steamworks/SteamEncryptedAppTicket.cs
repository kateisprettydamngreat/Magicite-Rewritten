using System;
using System.Runtime.InteropServices;

namespace Steamworks;

public static class SteamEncryptedAppTicket
{
	public static bool BDecryptTicket(byte[] rgubTicketEncrypted, uint cubTicketEncrypted, byte[] rgubTicketDecrypted, out uint pcubTicketDecrypted, byte[] rgubKey, int cubKey)
	{
		return NativeMethods.BDecryptTicket(rgubTicketEncrypted, cubTicketEncrypted, rgubTicketDecrypted, out pcubTicketDecrypted, rgubKey, cubKey);
	}

	public static bool BIsTicketForApp(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
	{
		return NativeMethods.BIsTicketForApp(rgubTicketDecrypted, cubTicketDecrypted, nAppID);
	}

	public static uint GetTicketIssueTime(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
	{
		return NativeMethods.GetTicketIssueTime(rgubTicketDecrypted, cubTicketDecrypted);
	}

	public static void GetTicketSteamID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID)
	{
		NativeMethods.GetTicketSteamID(rgubTicketDecrypted, cubTicketDecrypted, out psteamID);
	}

	public static uint GetTicketAppID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
	{
		return NativeMethods.GetTicketAppID(rgubTicketDecrypted, cubTicketDecrypted);
	}

	public static bool BUserOwnsAppInTicket(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
	{
		return NativeMethods.BUserOwnsAppInTicket(rgubTicketDecrypted, cubTicketDecrypted, nAppID);
	}

	public static bool BUserIsVacBanned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
	{
		return NativeMethods.BUserIsVacBanned(rgubTicketDecrypted, cubTicketDecrypted);
	}

	public static byte[] GetUserVariableData(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData)
	{
		IntPtr userVariableData = NativeMethods.GetUserVariableData(rgubTicketDecrypted, cubTicketDecrypted, out pcubUserData);
		byte[] array = new byte[pcubUserData];
		Marshal.Copy(userVariableData, array, 0, (int)pcubUserData);
		return array;
	}
}
