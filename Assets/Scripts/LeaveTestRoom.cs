using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveTestRoom : MonoBehaviour {

	void OnTriggerEnter(Collider other) {

		print("Loading...");
		SceneManager.LoadScene ("beach", LoadSceneMode.Single);
		print("Loaded!");

	}
}
