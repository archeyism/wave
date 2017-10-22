using UnityEngine;
using System.Collections;

public class WaveGen : MonoBehaviour
{
	float scale = 0.4f;
	float freqamplifier = 2.0f;

	//DO NOT TOUCH
	float freq = 0.628f;

	private Vector3[] baseHeight;

	void Start () {
		Mesh mesh = GetComponent<MeshFilter>().mesh;

		if (baseHeight == null)
			baseHeight = mesh.vertices;

		Vector3[] vertices = new Vector3[baseHeight.Length];
		for (int i=0;i<vertices.Length;i++)
		{
			Vector3 vertex = baseHeight[i];
			vertex.y += Mathf.Sin((baseHeight[i].y + baseHeight[i].x) * freq * freqamplifier) * scale;
			vertices[i] = vertex;
		}
		mesh.vertices = vertices;
		mesh.RecalculateNormals();
	}
}