using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(712)]
public struct PS3PSNStatusChange_t
{
	public const int k_iCallback = 712;

	[MarshalAs(UnmanagedType.I1)]
	public bool m_bPSNOnline;
}
