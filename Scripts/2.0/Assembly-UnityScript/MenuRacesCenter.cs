using System;
using UnityEngine;

[Serializable]
public class MenuRacesCenter : MonoBehaviour
{
	public GameObject g;

	private MenuScript gameScript;

	public virtual void Awake()
	{
		gameScript = (MenuScript)g.GetComponent("MenuScript");
	}

	public virtual void OnMouseExit()
	{
		gameScript.SetRace(99);
	}

	public virtual void Main()
	{
	}
}
