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

	public double m_InterpolationBackTime = 0.1;

	public double m_ExtrapolationLimit = 0.5;

	private State[] m_BufferedState = new State[20];

	private int m_TimestampCount;

	private void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (stream.isWriting)
		{
			Vector3 position = ((Component)this).rigidbody.position;
			Quaternion rotation = ((Component)this).rigidbody.rotation;
			Vector3 velocity = ((Component)this).rigidbody.velocity;
			Vector3 angularVelocity = ((Component)this).rigidbody.angularVelocity;
			stream.Serialize(ref position);
			stream.Serialize(ref velocity);
			stream.Serialize(ref rotation);
			stream.Serialize(ref angularVelocity);
			return;
		}
		Vector3 zero = Vector3.zero;
		Vector3 zero2 = Vector3.zero;
		Quaternion identity = Quaternion.identity;
		Vector3 zero3 = Vector3.zero;
		stream.Serialize(ref zero);
		stream.Serialize(ref zero2);
		stream.Serialize(ref identity);
		stream.Serialize(ref zero3);
		for (int num = m_BufferedState.Length - 1; num >= 1; num--)
		{
			ref State reference = ref m_BufferedState[num];
			reference = m_BufferedState[num - 1];
		}
		State state = default(State);
		state.timestamp = ((NetworkMessageInfo)(ref info)).timestamp;
		state.pos = zero;
		state.velocity = zero2;
		state.rot = identity;
		state.angularVelocity = zero3;
		m_BufferedState[0] = state;
		m_TimestampCount = Mathf.Min(m_TimestampCount + 1, m_BufferedState.Length);
		for (int i = 0; i < m_TimestampCount - 1; i++)
		{
			if (m_BufferedState[i].timestamp < m_BufferedState[i + 1].timestamp)
			{
				Debug.Log((object)"State inconsistent");
			}
		}
	}

	private void Update()
	{
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
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
					float num3 = 0f;
					if (num2 > 0.0001)
					{
						num3 = (float)((num - state2.timestamp) / num2);
					}
					((Component)this).transform.localPosition = Vector3.Lerp(state2.pos, state.pos, num3);
					((Component)this).transform.localRotation = Quaternion.Slerp(state2.rot, state.rot, num3);
					break;
				}
			}
			return;
		}
		State state3 = m_BufferedState[0];
		float num4 = (float)(num - state3.timestamp);
		if ((double)num4 < m_ExtrapolationLimit)
		{
			float num5 = num4 * ((Vector3)(ref state3.angularVelocity)).magnitude * 57.29578f;
			Quaternion val = Quaternion.AngleAxis(num5, state3.angularVelocity);
			((Component)this).rigidbody.position = state3.pos + state3.velocity * num4;
			((Component)this).rigidbody.rotation = val * state3.rot;
			if (!((Component)this).rigidbody.isKinematic)
			{
				((Component)this).rigidbody.velocity = state3.velocity;
				((Component)this).rigidbody.angularVelocity = state3.angularVelocity;
			}
		}
	}
}
