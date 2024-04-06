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
		switch (a)
		{
			case 0:
				text = "Ryvenrath praises your strength, +5 ATK";
				break;
			case 1:
				text = "Ryvenrath roars with fury, -1  MAX HP";
				break;
			case 2:
				text = "Maalurk approves of your power, +2 ALL STATS";
				break;
			case 3:
				text = "Maalurk revels in your pain, -1 HP";
				break;
			case 4:
				text = "Eoqueth blesses you, FULL HP";
				break;
			case 5:
				text = "Eoqueth ignores your request";
				break;
			case 6:
				text = "Pegelda admires your prowess, + 5 DEX";
				break;
			case 7:
				text = "Pegelda thinks you're unworthy";
				break;
			default:
				text = string.Empty;
				break;
		}

		@base.text = text;
		base2.text = text;
	}

	}