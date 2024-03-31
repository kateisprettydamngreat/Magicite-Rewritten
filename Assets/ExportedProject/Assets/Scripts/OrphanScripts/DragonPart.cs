using System;
using UnityEngine;

[Serializable]
public class DragonPart : MonoBehaviour
{
	public GameObject parent;

	public virtual void Start()
	{
	}

	public virtual void TD(int dmg)
	{
		parent.SendMessage("TD", dmg);
	}

	public virtual void K()
	{
	}

	public virtual void KN()
	{
	}

	}