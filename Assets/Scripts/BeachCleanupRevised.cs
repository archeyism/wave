using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeachCleanupRevised : MonoBehaviour {

	public GameObject player;

	void Start () {
		player = GameObject.Find("Game Controller");
	}

	void Update () {
		if (player.transform.position.z > (gameObject.transform.position.z + 250)) {
			gameObject.transform.position = new Vector3(0, 0, gameObject.transform.position.z + 500);
		}
		if (player.transform.position.z < (gameObject.transform.position.z - 250)) {
			gameObject.transform.position = new Vector3(0, 0, gameObject.transform.position.z - 500);
		}
	}
}
