using System;
using UnityEngine;

[Serializable]
public class CoinTrigger : MonoBehaviour
{
	public GameObject Parent;

	public virtual void Start()
	{
	}

	public virtual void Die()
	{
		UnityEngine.Object.Destroy(gameObject);
	}

	public virtual void Main()
	{
	}
}
