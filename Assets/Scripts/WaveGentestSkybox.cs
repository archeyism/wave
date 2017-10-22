using UnityEngine;
using System.Collections;

public class WaveGentestSkybox : MonoBehaviour
{
	public float xscale = 0.1f;
	public float yscale = 0.1f;
	public float zscale = 0.1f;
	public float speed = 0.7f;
	public float xfreqamplifier = 2.0f;
	public float yfreqamplifier = 2.0f;
	public float zfreqamplifier = 2.0f;

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
			vertex.z += Mathf.Sin((Time.time * speed+ baseHeight[i].y) * freq * yfreqamplifier) * yscale;
			vertex.z += Mathf.Sin((Time.time * speed+ baseHeight[i].x) * freq * xfreqamplifier) * xscale;
			vertex.z += Mathf.Sin((Time.time * speed+ baseHeight[i].z) * freq * zfreqamplifier) * zscale;
			vertices[i] = vertex;
		}
		mesh.vertices = vertices;
		mesh.RecalculateNormals();
	}
}