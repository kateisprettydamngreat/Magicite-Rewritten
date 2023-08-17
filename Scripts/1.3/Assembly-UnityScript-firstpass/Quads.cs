using System;
using UnityEngine;

[Serializable]
public class Quads : MonoBehaviour
{
	[NonSerialized]
	public static Mesh[] meshes;

	[NonSerialized]
	public static int currentQuads;

	public static bool HasMeshes()
	{
		int result;
		if (meshes == null)
		{
			result = 0;
		}
		else
		{
			int num = 0;
			Mesh[] array = meshes;
			int length = array.Length;
			while (true)
			{
				if (num < length)
				{
					if ((Object)null == (Object)(object)array[num])
					{
						result = 0;
						break;
					}
					num++;
					continue;
				}
				result = 1;
				break;
			}
		}
		return (byte)result != 0;
	}

	public static void Cleanup()
	{
		if (meshes == null)
		{
			return;
		}
		int i = 0;
		Mesh[] array = meshes;
		for (int length = array.Length; i < length; i++)
		{
			if ((Object)null != (Object)(object)array[i])
			{
				Object.DestroyImmediate((Object)(object)array[i]);
				array[i] = null;
			}
		}
		meshes = null;
	}

	public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
	{
		Mesh[] result;
		if (HasMeshes() && currentQuads == totalWidth * totalHeight)
		{
			result = meshes;
		}
		else
		{
			int num = 10833;
			int num2 = (currentQuads = totalWidth * totalHeight);
			int num3 = Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num));
			meshes = (Mesh[])(object)new Mesh[num3];
			int num4 = 0;
			int num5 = 0;
			for (num4 = 0; num4 < num2; num4 += num)
			{
				int triCount = Mathf.FloorToInt((float)Mathf.Clamp(num2 - num4, 0, num));
				meshes[num5] = GetMesh(triCount, num4, totalWidth, totalHeight);
				num5++;
			}
			result = meshes;
		}
		return result;
	}

	public static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		Mesh val = new Mesh();
		((Object)val).hideFlags = (HideFlags)4;
		Vector3[] array = (Vector3[])(object)new Vector3[triCount * 4];
		Vector2[] array2 = (Vector2[])(object)new Vector2[triCount * 4];
		Vector2[] array3 = (Vector2[])(object)new Vector2[triCount * 4];
		int[] array4 = new int[triCount * 6];
		float num = 0.0075f;
		for (int i = 0; i < triCount; i++)
		{
			int num2 = i * 4;
			int num3 = i * 6;
			int num4 = triOffset + i;
			float num5 = Mathf.Floor((float)(num4 % totalWidth)) / (float)totalWidth;
			float num6 = Mathf.Floor((float)(num4 / totalWidth)) / (float)totalHeight;
			Vector3 val2 = new Vector3(num5 * 2f - 1f, num6 * 2f - 1f, 1f);
			array[num2 + 0] = val2;
			array[num2 + 1] = val2;
			array[num2 + 2] = val2;
			array[num2 + 3] = val2;
			ref Vector2 reference = ref array2[num2 + 0];
			reference = new Vector2(0f, 0f);
			ref Vector2 reference2 = ref array2[num2 + 1];
			reference2 = new Vector2(1f, 0f);
			ref Vector2 reference3 = ref array2[num2 + 2];
			reference3 = new Vector2(0f, 1f);
			ref Vector2 reference4 = ref array2[num2 + 3];
			reference4 = new Vector2(1f, 1f);
			ref Vector2 reference5 = ref array3[num2 + 0];
			reference5 = new Vector2(num5, num6);
			ref Vector2 reference6 = ref array3[num2 + 1];
			reference6 = new Vector2(num5, num6);
			ref Vector2 reference7 = ref array3[num2 + 2];
			reference7 = new Vector2(num5, num6);
			ref Vector2 reference8 = ref array3[num2 + 3];
			reference8 = new Vector2(num5, num6);
			array4[num3 + 0] = num2 + 0;
			array4[num3 + 1] = num2 + 1;
			array4[num3 + 2] = num2 + 2;
			array4[num3 + 3] = num2 + 1;
			array4[num3 + 4] = num2 + 2;
			array4[num3 + 5] = num2 + 3;
		}
		val.vertices = array;
		val.triangles = array4;
		val.uv = array2;
		val.uv2 = array3;
		return val;
	}

	public override void Main()
	{
	}
}
