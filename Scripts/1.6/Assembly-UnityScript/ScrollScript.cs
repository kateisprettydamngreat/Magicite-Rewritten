using System;
using UnityEngine;

[Serializable]
public class ScrollScript : MonoBehaviour
{
	private Renderer r;

	public override void Start()
	{
		r = ((Component)this).renderer;
	}

	public override void Update()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		float x = r.material.mainTextureOffset.x + Time.deltaTime * 0.02f;
		Vector2 mainTextureOffset = r.material.mainTextureOffset;
		float num = (mainTextureOffset.x = x);
		Vector2 val2 = (r.material.mainTextureOffset = mainTextureOffset);
		float y = r.material.mainTextureOffset.y + Time.deltaTime * 0.02f;
		Vector2 mainTextureOffset2 = r.material.mainTextureOffset;
		float num2 = (mainTextureOffset2.y = y);
		Vector2 val4 = (r.material.mainTextureOffset = mainTextureOffset2);
	}

	public override void Main()
	{
	}
}
