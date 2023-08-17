using System;
using UnityEngine;

[Serializable]
public class NPCBasicScript : MonoBehaviour
{
	public bool isChild;

	public GameObject head;

	public GameObject body;

	public GameObject leg;

	public Material maleLeg;

	public Material femaleLeg;

	private int maxC;

	private int maxA;

	public NPCBasicScript()
	{
		maxC = 5;
		maxA = 5;
	}

	public override void Start()
	{
		if (MenuScript.multiplayer > 0)
		{
			if (isChild)
			{
				((Component)this).networkView.RPC("CreateChild", (RPCMode)6, new object[2]
				{
					Random.Range(0, maxC),
					Random.Range(0, maxC)
				});
			}
			else
			{
				((Component)this).networkView.RPC("CreateAdult", (RPCMode)6, new object[2]
				{
					Random.Range(0, maxA),
					Random.Range(0, maxA)
				});
			}
		}
		else if (isChild)
		{
			CreateChild(Random.Range(0, maxC), Random.Range(0, maxC));
		}
		else
		{
			CreateAdult(Random.Range(0, maxC), Random.Range(0, maxC));
		}
	}

	[RPC]
	public override void CreateChild(int h, int b)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		int num = Random.Range(0, 3);
		if (num < 2)
		{
			head.renderer.material = (Material)Resources.Load("cHM" + (object)h);
			body.renderer.material = (Material)Resources.Load("cBM" + (object)b);
		}
		else
		{
			head.renderer.material = (Material)Resources.Load("cHF" + (object)h);
			body.renderer.material = (Material)Resources.Load("cBF" + (object)b);
		}
	}

	[RPC]
	public override void CreateAdult(int h, int b)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		int num = Random.Range(0, 3);
		if (num < 2)
		{
			head.renderer.material = (Material)Resources.Load("aHM" + (object)h);
			body.renderer.material = (Material)Resources.Load("aBM" + (object)b);
			leg.renderer.material = maleLeg;
		}
		else
		{
			head.renderer.material = (Material)Resources.Load("aHF" + (object)h);
			body.renderer.material = (Material)Resources.Load("aBF" + (object)b);
			leg.renderer.material = femaleLeg;
		}
	}

	public override void Main()
	{
	}
}
