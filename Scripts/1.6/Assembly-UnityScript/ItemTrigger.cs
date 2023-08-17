using System;
using UnityEngine;

[Serializable]
public class ItemTrigger : MonoBehaviour
{
	public GameObject Parent;

	private ItemScript itemScript;

	public override void Awake()
	{
		itemScript = (ItemScript)(object)Parent.GetComponent("ItemScript");
	}

	public override void Start()
	{
	}

	public override void Hit(GameObject g)
	{
		itemScript.Hit(g);
	}

	public override void Die()
	{
		if (MenuScript.multiplayer > 0)
		{
			Parent.SendMessage("D");
		}
		else
		{
			Object.Destroy((Object)(object)Parent.gameObject);
		}
	}

	public override void Main()
	{
	}
}
