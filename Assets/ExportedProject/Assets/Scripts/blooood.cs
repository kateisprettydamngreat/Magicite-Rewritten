using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class blooood : MonoBehaviour
{
	public IEnumerator Start()
	{
		yield return new WaitForSeconds(1f);

		Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
		Network.Destroy(GetComponent<NetworkView>().viewID);
	}
}
