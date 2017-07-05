using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightOnTouch : MonoBehaviour {
	private Color normalColor;
	private Color highlightColor;

	void Start() {
		Material material = GetComponent<MeshRenderer>().material;
		normalColor = material.color;

		highlightColor = new Color(
			normalColor.r * 0.5f,
			normalColor.g * 0.5f,
			normalColor.b * 0.5f
		);
	}

	void Update() {
		if (Input.GetMouseButtonDown(0)) {
			
		}
	}
}
