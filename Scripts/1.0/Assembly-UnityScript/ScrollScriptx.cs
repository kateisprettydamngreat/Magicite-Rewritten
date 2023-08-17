using System;
using UnityEngine;

[Serializable]
public class ScrollScriptx : MonoBehaviour
{
	public float speed;

	public float speedY;

	private Renderer r;

	public override void Start()
	{
		r = ((Component)this).renderer;
	}

	public override void Update()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		float x = r.material.mainTextureOffset.x + speed * Time.deltaTime;
		Vector2 mainTextureOffset = r.material.mainTextureOffset;
		float num = (mainTextureOffset.x = x);
		Vector2 val2 = (r.material.mainTextureOffset = mainTextureOffset);
		float y = r.material.mainTextureOffset.y + speedY * Time.deltaTime;
		Vector2 mainTextureOffset2 = r.material.mainTextureOffset;
		float num2 = (mainTextureOffset2.y = y);
		Vector2 val4 = (r.material.mainTextureOffset = mainTextureOffset2);
	}

	public override void Main()
	{
	}
}
