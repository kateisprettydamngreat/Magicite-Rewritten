using System;
using UnityEngine;

[Serializable]
public class SpriteScript : MonoBehaviour
{
	public Transform startMarker;

	public Transform endMarker;

	public GameObject p;

	public float speed;

	private bool initialized;

	private float startTime;

	private float journeyLength;

	public Transform target;

	public float smooth;

	public SpriteScript()
	{
		speed = 1f;
		smooth = 5f;
	}

	public override void Awake()
	{
		Object.DontDestroyOnLoad((Object)(object)this);
	}

	public override void OnLevelWasLoaded(int level)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = new Vector3(0f, 0f, 0f);
	}

	[RPC]
	public override void SETN(GameObject a)
	{
		p = a;
	}

	public override void Set(GameObject a)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		p = a;
		startTime = Time.time;
		startMarker = p.transform;
		endMarker = ((Component)this).transform;
		journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
		initialized = true;
	}

	public override void Start()
	{
	}

	public override void Update()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (initialized)
		{
			float num = (Time.time - startTime) * speed;
			float num2 = num / journeyLength;
			((Component)this).transform.localPosition = Vector3.Lerp(startMarker.position, endMarker.position, 0.99f);
		}
	}

	public override void Main()
	{
	}
}
