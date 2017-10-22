using UnityEngine;
using System.Collections;

public class FloatOnWaves : MonoBehaviour
{
	public float scale = 0.1f;
	public float speed = 0.7f;
	public float freqamplifier = 2.0f;

	//DO NOT TOUCH
	float freq = 0.628f;

	void Update () {
		
		transform.localPosition = new Vector3(transform.position.x,transform.position.y + (Mathf.Sin ((Time.time * speed) * freq * freqamplifier) * scale),transform.position.z);
		transform.Rotate(Vector3.forward, 180.0f * (Mathf.Sin ((Time.time * (speed*2.0f)) * freq * freqamplifier) * scale));

	}
}