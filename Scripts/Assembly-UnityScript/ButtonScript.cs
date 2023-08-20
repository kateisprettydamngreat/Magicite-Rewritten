using System;
using UnityEngine;

[Serializable]
public class ButtonScript : MonoBehaviour
{
	public GameObject shade;

	private bool played;

	public virtual void OnMouseOver()
	{
		if (!played)
		{
			played = true;
			GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/CLICKh", typeof(AudioClip)));
		}
		shade.SetActive(value: true);
	}

	public virtual void OnMouseExit()
	{
		played = false;
		shade.SetActive(value: false);
	}

	public virtual void OnEnable()
	{
		shade.SetActive(value: false);
	}
