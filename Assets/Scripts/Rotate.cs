using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public float xspeed;
	public float yspeed;
	public float zspeed;

	void Update () {

		transform.Rotate(Vector3.left, (Time.deltaTime * yspeed));
		transform.Rotate(Vector3.down, (Time.deltaTime * xspeed));
		transform.Rotate(Vector3.forward, (Time.deltaTime * zspeed));

	}
}
