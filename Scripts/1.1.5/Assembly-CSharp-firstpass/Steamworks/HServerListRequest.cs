using System;

namespace Steamworks;

public struct HServerListRequest
{
	public IntPtr m_HServerListRequest;

	public HServerListRequest(IntPtr value)
	{
		m_HServerListRequest = value;
	}

	public override string ToString()
	{
		return m_HServerListRequest.ToString();
	}
}
