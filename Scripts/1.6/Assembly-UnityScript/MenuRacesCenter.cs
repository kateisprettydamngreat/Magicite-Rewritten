using System;
using UnityEngine;

[Serializable]
public class MenuRacesCenter : MonoBehaviour
{
	public GameObject g;

	private MenuScript gameScript;

	public override void Awake()
	{
		gameScript = (MenuScript)(object)g.GetComponent("MenuScript");
	}

	public override void OnMouseExit()
	{
		gameScript.SetRace(99);
	}

	public override void Main()
	{
	}
}
