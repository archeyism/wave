using UnityEngine;
using System.Collections;

public class WaveGentest : MonoBehaviour
{
	public float scale = 0.1f;
	public float speed = 0.7f;
	public float freqamplifier = 2.0f;

	//DO NOT TOUCH
	float freq = 0.628f;

	private Vector3[] baseHeight;

	void Update () {
		Mesh mesh = GetComponent<MeshFilter>().mesh;

		if (baseHeight == null)
			baseHeight = mesh.vertices;

		Vector3[] vertices = new Vector3[baseHeight.Length];
		for (int i=0;i<vertices.Length;i++)
		{
			Vector3 vertex = baseHeight[i];
			vertex.y += Mathf.Sin((Time.time * speed+ baseHeight[i].y + baseHeight[i].z) * freq * freqamplifier) * scale;
			vertices[i] = vertex;
		}
		mesh.vertices = vertices;
		mesh.RecalculateNormals();
	}
}