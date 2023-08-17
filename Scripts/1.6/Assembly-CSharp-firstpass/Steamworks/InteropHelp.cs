using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Steamworks;

public class InteropHelp
{
	public class UTF8String
	{
		private IntPtr m_NativeString;

		public UTF8String(string managedString)
		{
			if (string.IsNullOrEmpty(managedString))
			{
				m_NativeString = IntPtr.Zero;
				return;
			}
			byte[] array = new byte[Encoding.UTF8.GetByteCount(managedString) + 1];
			Encoding.UTF8.GetBytes(managedString, 0, managedString.Length, array, 0);
			m_NativeString = Marshal.AllocHGlobal(array.Length);
			Marshal.Copy(array, 0, m_NativeString, array.Length);
		}

		~UTF8String()
		{
			if (m_NativeString != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(m_NativeString);
			}
		}

		public static implicit operator IntPtr(UTF8String that)
		{
			return that.m_NativeString;
		}
	}

	public class SteamParamStringArray
	{
		private IntPtr m_pSteamParamStringArray;

		private IntPtr[] m_Strings;

		public SteamParamStringArray(IList<string> strings)
		{
			if (strings == null)
			{
				m_pSteamParamStringArray = IntPtr.Zero;
				return;
			}
			m_Strings = new IntPtr[strings.Count];
			for (int i = 0; i < strings.Count; i++)
			{
				ref IntPtr reference = ref m_Strings[i];
				reference = new UTF8String(strings[i]);
			}
			SteamParamStringArray_t steamParamStringArray_t = new SteamParamStringArray_t
			{
				m_ppStrings = m_Strings,
				m_nNumStrings = strings.Count
			};
			m_pSteamParamStringArray = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SteamParamStringArray_t)));
			Marshal.StructureToPtr(steamParamStringArray_t, m_pSteamParamStringArray, fDeleteOld: false);
		}

		~SteamParamStringArray()
		{
			if (m_pSteamParamStringArray != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(m_pSteamParamStringArray);
			}
		}

		public static implicit operator IntPtr(SteamParamStringArray that)
		{
			return that.m_pSteamParamStringArray;
		}
	}

	public static string PtrToStringUTF8(IntPtr nativeUtf8)
	{
		if (nativeUtf8 == IntPtr.Zero)
		{
			return string.Empty;
		}
		int i;
		for (i = 0; Marshal.ReadByte(nativeUtf8, i) != 0; i++)
		{
		}
		if (i == 0)
		{
			return string.Empty;
		}
		byte[] array = new byte[i];
		Marshal.Copy(nativeUtf8, array, 0, array.Length);
		return Encoding.UTF8.GetString(array);
	}
}
