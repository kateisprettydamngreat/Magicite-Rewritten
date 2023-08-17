using System;
using UnityEngine;

[Serializable]
public class TownScript : MonoBehaviour
{
	public GameObject floor1;

	public GameObject floor2;

	public GameObject platform1;

	public GameObject platform2;

	public override void Start()
	{
	}

	[RPC]
	public override void SetPlatforms(int b)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		floor1.renderer.material = (Material)Resources.Load("floor/p" + (object)b, typeof(Material));
		floor2.renderer.material = (Material)Resources.Load("floor/p" + (object)b, typeof(Material));
		platform1.renderer.material = (Material)Resources.Load("platformS/p" + (object)b, typeof(Material));
		platform2.renderer.material = (Material)Resources.Load("platformS/p" + (object)b, typeof(Material));
	}

	public override void Main()
	{
	}
}
