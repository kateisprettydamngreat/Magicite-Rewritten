using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class GrassScript : MonoBehaviour
{
    public IEnumerator Start()
    {
        drop = GetPlantItem(UnityEngine.Random.Range(0, 4));
        r = @base.GetComponent<Renderer>();
        yield return new WaitForSeconds(0.5f);
        float newOffsetX = r.material.mainTextureOffset.x + 0.5f;
        r.material.mainTextureOffset = new Vector2(newOffsetX, r.material.mainTextureOffset.y);
    }

    [RPC]
    public IEnumerator Exile()
    {
        if (!exiling)
        {
            exiling = true;
            transform.position = new Vector3(0f, 0f, -500f);
            yield return new WaitForSeconds(4f);
            if (Network.isServer)
            {
                NetworkView networkView = GetComponent<NetworkView>();
                Network.Destroy(networkView.viewID);
                Network.RemoveRPCs(networkView.viewID);
            }
        }
	}

	public GameObject @base;
	private Renderer r;
	private int drop;
	private bool exiling;


	public virtual void TD(int dmg)
	{
		int num = default(int);
		GameObject gameObject = null;
		GetComponent<NetworkView>().RPC("TD2", RPCMode.All, dmg);
	}
	[RPC]
	public virtual void TD2(int dmg)
	{
		GameScript.tempStats[7] = GameScript.tempStats[7] + 1;
		int num = default(int);
		GameObject gameObject = null;
		int q = 1;
		int[] array = null;
		if ((MenuScript.curTrait[2] == 3 || MenuScript.curTrait[1] == 3) && UnityEngine.Random.Range(0, 2) == 0)
		{
			q = 2;
		}
		Item item = new Item(drop, q, new int[4], 0f, null);
		if (GameScript.tempStats[7] > 9)
		{
			MenuScript.canUnlockHat[1] = 1;
		}
		if (dmg > 10)
		{
			dmg -= 10;
			if (UnityEngine.Random.Range(0, 4) == 0)
			{
				int id = UnityEngine.Random.Range(1, 57);
				Item item2 = new Item(id, 1, new int[4], 0f, null);
				GameObject gameObject2 = null;
				gameObject2 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), transform.position, Quaternion.identity);
				array = new int[7] { item2.id, item2.q, 0, 0, 0, 0, 0 };
				gameObject2.SendMessage("InitL", array);
			}
		}
		int num2 = default(int);
		for (num = 0; num < dmg; num++)
		{
			if (num != 0)
			{
				if (UnityEngine.Random.Range(0, 2) == 0)
				{
					gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), transform.position, Quaternion.identity);
					array = new int[7] { item.id, item.q, 0, 0, 0, 0, 0 };
					gameObject.SendMessage("InitL", array);
				}
			}
			else
			{
				gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), transform.position, Quaternion.identity);
				array = new int[7] { item.id, item.q, 0, 0, 0, 0, 0 };
				gameObject.SendMessage("InitL", array);
			}
		}
		transform.position = new Vector3(0f, 0f, -500f);
		if (Network.isServer)
		{
			StartCoroutine_Auto(Exile());
		}
	}
	public virtual int GetPlantItem(int a)
	{
		int num = default(int);
		return a switch
		{
			0 => 9, 
			1 => 10, 
			2 => 10, 
			3 => 23, 
			_ => num, 
		};
	}
	}