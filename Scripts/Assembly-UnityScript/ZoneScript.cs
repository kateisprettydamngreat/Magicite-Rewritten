using System;
using UnityEngine;

[Serializable]
public class ZoneScript : MonoBehaviour
{
	public virtual void Awake()
	{
		int num = UnityEngine.Random.Range(1, 6);
	}

	}