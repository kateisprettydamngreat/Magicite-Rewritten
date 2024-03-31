using System;
using UnityEngine;

[Serializable]
public class txtAltar : MonoBehaviour
{
	public TextMesh base2;

	public TextMesh @base;

	public virtual void Start()
	{
	}

	public virtual void Set(int a)
	{
		string text = null;
		text = a switch
		{
			0 => "Ryvenrath praises your strength, +5 ATK", 
			1 => "Ryvenrath roars with fury, -1  MAX HP", 
			2 => "Maalurk approves of your power, +2 ALL STATS", 
			3 => "Maalurk revels in your pain, -1 HP", 
			4 => "Eoqueth blesses you, FULL HP", 
			5 => "Eoqueth ignores your request", 
			6 => "Pegelda admires your prowess, + 5 DEX", 
			7 => "Pegelda thinks you're unworthy", 
			_ => string.Empty, 
		};
		@base.text = text;
		base2.text = text;
	}

	}