using System;
using UnityEngine;

[Serializable]
public class FortuneScript : MonoBehaviour
{
	private bool gooing;

	public virtual void Go()
	{
		if (!gooing)
		{
			gooing = true;
			GetComponent<NetworkView>().RPC("GON", RPCMode.All);
		}
	}

	[RPC]
	public virtual void GON()
	{
		gooing = true;
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void Main()
	{
	}
}
