using System;
using UnityEngine;

[Serializable]
public class GhostScript : MonoBehaviour
{
	public GameObject bar;

	public GameObject player;

	private float revCount;

	private bool reviving;

	public virtual void Awake()
	{
		revCount = 0f;
	}

	public virtual void OnEnable()
	{
		revCount = 0f;
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (!reviving && c.gameObject.layer == 8)
		{
			reviving = true;
		}
	}

	public virtual void OnTriggerExit(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			reviving = false;
			revCount = 0f;
		}
	}

	public virtual void Update()
	{
		if (reviving)
		{
			revCount += 1f * Time.deltaTime;
			if (!(revCount < 5f))
			{
				player.SendMessage("Rev");
				player.GetComponent<NetworkView>().RPC("Revive", RPCMode.All);
				gameObject.SetActive(value: false);
				player.GetComponent<NetworkView>().RPC("RevCheck", RPCMode.Server);
			}
		}
		float x = revCount / 5f * 2f;
		Vector3 localScale = bar.transform.localScale;
		float num = (localScale.x = x);
		Vector3 vector2 = (bar.transform.localScale = localScale);
	}

	public virtual void Main()
	{
	}
}
