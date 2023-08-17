using System;
using UnityEngine;

[Serializable]
public class ButtonScript : MonoBehaviour
{
	public GameObject shade;

	private bool played;

	public override void OnMouseOver()
	{
		if (!played)
		{
			played = true;
		}
		shade.SetActive(true);
	}

	public override void OnMouseExit()
	{
		played = false;
		shade.SetActive(false);
	}

	public override void OnEnable()
	{
		shade.SetActive(false);
	}

	public override void Main()
	{
	}
}
