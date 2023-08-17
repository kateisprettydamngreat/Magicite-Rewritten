using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(709)]
public struct PS3NPMessageSelected_t
{
	public const int k_iCallback = 709;

	public uint dataid;
}
