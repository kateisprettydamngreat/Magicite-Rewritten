using UnityEngine;

public class NetworkRigidbody : MonoBehaviour
{
	internal struct State
	{
		internal double timestamp;

		internal Vector3 pos;

		internal Vector3 velocity;

		internal Quaternion rot;

		internal Vector3 angularVelocity;
	}

	public bool player;

	public GameObject p;

	public double m_InterpolationBackTime = 0.1;

	public double m_ExtrapolationLimit = 0.5;

	private Quaternion realRotation;

	private State[] m_BufferedState = new State[20];

	private int m_TimestampCount;

	private void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
	{
		if (stream.isWriting)
		{
			Vector3 value = GetComponent<Rigidbody>().position;
			Quaternion value2 = GetComponent<Rigidbody>().rotation;
			Vector3 value3 = GetComponent<Rigidbody>().velocity;
			Vector3 value4 = GetComponent<Rigidbody>().angularVelocity;
			stream.Serialize(ref value);
			stream.Serialize(ref value3);
			stream.Serialize(ref value2);
			stream.Serialize(ref value4);
			if (player)
			{
				float value5 = ((!(p != null)) ? 0f : p.transform.rotation.y);
				stream.Serialize(ref value5);
			}
			return;
		}
		Vector3 value6 = Vector3.zero;
		Vector3 value7 = Vector3.zero;
		Quaternion value8 = Quaternion.identity;
		Vector3 value9 = Vector3.zero;
		stream.Serialize(ref value6);
		stream.Serialize(ref value7);
		stream.Serialize(ref value8);
		stream.Serialize(ref value9);
		if (player)
		{
			float value10 = 0f;
			stream.Serialize(ref value10);
			realRotation = Quaternion.Euler(0f, value10, 0f);
		}
		for (int num = m_BufferedState.Length - 1; num >= 1; num--)
		{
			ref State reference = ref m_BufferedState[num];
			reference = m_BufferedState[num - 1];
		}
		State state = default(State);
		state.timestamp = info.timestamp;
		state.pos = value6;
		state.velocity = value7;
		state.rot = value8;
		state.angularVelocity = value9;
		m_BufferedState[0] = state;
		m_TimestampCount = Mathf.Min(m_TimestampCount + 1, m_BufferedState.Length);
		for (int i = 0; i < m_TimestampCount - 1; i++)
		{
			if (m_BufferedState[i].timestamp < m_BufferedState[i + 1].timestamp)
			{
				Debug.Log("State inconsistent");
			}
		}
	}

	private void Update()
	{
		if (!GetComponent<NetworkView>().isMine && player && p != null)
		{
			if (realRotation.y > 0f)
			{
				p.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
			}
			else
			{
				p.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			}
		}
		double num = Network.time - m_InterpolationBackTime;
		if (m_BufferedState[0].timestamp > num)
		{
			for (int i = 0; i < m_TimestampCount; i++)
			{
				if (m_BufferedState[i].timestamp <= num || i == m_TimestampCount - 1)
				{
					State state = m_BufferedState[Mathf.Max(i - 1, 0)];
					State state2 = m_BufferedState[i];
					double num2 = state.timestamp - state2.timestamp;
					float t = 0f;
					if (num2 > 0.0001)
					{
						t = (float)((num - state2.timestamp) / num2);
					}
					base.transform.localPosition = Vector3.Lerp(state2.pos, state.pos, t);
					base.transform.localRotation = Quaternion.Slerp(state2.rot, state.rot, t);
					break;
				}
			}
			return;
		}
		State state3 = m_BufferedState[0];
		float num3 = (float)(num - state3.timestamp);
		if ((double)num3 < m_ExtrapolationLimit)
		{
			float angle = num3 * state3.angularVelocity.magnitude * 57.29578f;
			Quaternion quaternion = Quaternion.AngleAxis(angle, state3.angularVelocity);
			GetComponent<Rigidbody>().position = state3.pos + state3.velocity * num3;
			GetComponent<Rigidbody>().rotation = quaternion * state3.rot;
			if (!GetComponent<Rigidbody>().isKinematic)
			{
				GetComponent<Rigidbody>().velocity = state3.velocity;
				GetComponent<Rigidbody>().angularVelocity = state3.angularVelocity;
			}
		}
	}
}
