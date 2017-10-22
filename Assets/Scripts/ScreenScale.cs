using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenScale : MonoBehaviour {

	public float Scale;
	private float priscale;

	void Start () {
		priscale = (Screen.height * Scale);
		GetComponent<RectTransform>().sizeDelta = new Vector2 (priscale*1.33333f,priscale);
	}
}