using System;
using UnityEngine;

[Serializable]
public class txtAltar : MonoBehaviour
{
	public TextMesh @base;

	public override void Start()
	{
	}

	public override void Update()
	{
	}

	public override void Set(int a)
	{
		((Component)this).networkView.RPC("SetN", (RPCMode)2, new object[1] { a });
	}

	[RPC]
	public override void SetN(int a)
	{
		string text = null;
		switch (a)
		{
		case 0:
			text = "Ryvenrath praises you, +2 ATK!";
			break;
		case 1:
			text = "Ryvenrath is not pleased. -1 HP.";
			break;
		}
	}

	public override void Main()
	{
	}
}
