using System;
using UnityEngine;

[Serializable]
public class FortuneScript : MonoBehaviour
{
	private bool gooing;

	public override void Go()
	{
		if (!gooing)
		{
			gooing = true;
			((Component)this).networkView.RPC("GON", (RPCMode)2, new object[0]);
		}
	}

	[RPC]
	public override void GON()
	{
		gooing = true;
	}

	public override void Start()
	{
	}

	public override void Update()
	{
	}

	public override void Main()
	{
	}
}
