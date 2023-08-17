using System;
using UnityEngine;

[Serializable]
public class ItemTrigger : MonoBehaviour
{
	public GameObject Parent;

	private ItemScript itemScript;

	public virtual void Awake()
	{
		itemScript = (ItemScript)Parent.GetComponent("ItemScript");
	}

	public virtual void Start()
	{
	}

	public virtual void Hit(GameObject g)
	{
		itemScript.Hit(g);
	}

	public virtual void Die()
	{
		Parent.SendMessage("D");
	}

	public virtual void Main()
	{
	}
}
