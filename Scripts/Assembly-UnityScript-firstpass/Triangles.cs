using System;
using UnityEngine;

[Serializable]
public class Triangles : MonoBehaviour
{
	[NonSerialized]
	public static Mesh[] meshes;

	[NonSerialized]
	public static int currentTris;

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
					if (null == array[num])
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
			if (null != array[i])
			{
				UnityEngine.Object.DestroyImmediate(array[i]);
				array[i] = null;
			}
		}
		meshes = null;
	}

	public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
	{
		Mesh[] result;
		if (HasMeshes() && currentTris == totalWidth * totalHeight)
		{
			result = meshes;
		}
		else
		{
			int num = 21666;
			int num2 = (currentTris = totalWidth * totalHeight);
			int num3 = Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num));
			meshes = new Mesh[num3];
			int num4 = 0;
			int num5 = 0;
			for (num4 = 0; num4 < num2; num4 += num)
			{
				int triCount = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
				meshes[num5] = GetMesh(triCount, num4, totalWidth, totalHeight);
				num5++;
			}
			result = meshes;
		}
		return result;
	}

	public static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSave;
		Vector3[] array = new Vector3[triCount * 3];
		Vector2[] array2 = new Vector2[triCount * 3];
		Vector2[] array3 = new Vector2[triCount * 3];
		int[] array4 = new int[triCount * 3];
		float num = 0.0075f;
		for (int i = 0; i < triCount; i++)
		{
			int num2 = i * 3;
			int num3 = triOffset + i;
			float num4 = Mathf.Floor(num3 % totalWidth) / (float)totalWidth;
			float num5 = Mathf.Floor(num3 / totalWidth) / (float)totalHeight;
			Vector3 vector = new Vector3(num4 * 2f - 1f, num5 * 2f - 1f, 1f);
			array[num2 + 0] = vector;
			array[num2 + 1] = vector;
			array[num2 + 2] = vector;
			ref Vector2 reference = ref array2[num2 + 0];
			reference = new Vector2(0f, 0f);
			ref Vector2 reference2 = ref array2[num2 + 1];
			reference2 = new Vector2(1f, 0f);
			ref Vector2 reference3 = ref array2[num2 + 2];
			reference3 = new Vector2(0f, 1f);
			ref Vector2 reference4 = ref array3[num2 + 0];
			reference4 = new Vector2(num4, num5);
			ref Vector2 reference5 = ref array3[num2 + 1];
			reference5 = new Vector2(num4, num5);
			ref Vector2 reference6 = ref array3[num2 + 2];
			reference6 = new Vector2(num4, num5);
			array4[num2 + 0] = num2 + 0;
			array4[num2 + 1] = num2 + 1;
			array4[num2 + 2] = num2 + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	public virtual void Main()
	{
	}
}
