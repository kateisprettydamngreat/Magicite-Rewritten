using System;

[Serializable]
public enum EdgeDetectMode
{
	TriangleDepthNormals,
	RobertsCrossDepthNormals,
	SobelDepth,
	SobelDepthThin
}
