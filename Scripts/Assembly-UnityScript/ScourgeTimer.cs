using System;
using UnityEngine;

[Serializable]
public class ScourgeTimer : MonoBehaviour
{
	public GameObject gameManager;

	public GameObject cursor;

	private GameScript gameScript;

	[NonSerialized]
	public static float curTime;

	private float maxTime;

	public ScourgeTimer()
	{
		maxTime = 10f;
	}

	public virtual void Awake()
	{
		gameScript = (GameScript)gameManager.GetComponent("GameScript");
		Tick();
	}

	public virtual void Tick()
	{
	}

	public virtual void Main()
	{
	}
}
