using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtHimCollider : MonoBehaviour {

	public LookAtHim ascript;
	public DefaultOrientation bscript;

	void Start () {
		ascript = GameObject.Find("RotationController").GetComponent<LookAtHim>();
		ascript.enabled = false;
		bscript = GameObject.Find("RotationController").GetComponent<DefaultOrientation>();
		bscript.enabled = true;
	}
	
	void OnTriggerEnter(Collider other) {
		ascript.enabled = true;
		bscript.enabled = false;
	}

	void OnTriggerExit(Collider other) {
		ascript.enabled = false;
		bscript.enabled = true;
	}
}