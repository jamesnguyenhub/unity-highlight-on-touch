using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightOnTouch : MonoBehaviour {
	private Material material;
	private Color normalColor;
	private Color highlightColor;
	private bool touching;
	private float interval;

	void Start() {
		material = GetComponent<MeshRenderer>().material;

		normalColor = material.color;
		highlightColor = new Color(
			normalColor.r * 1.5f,
			normalColor.g * 1.5f,
			normalColor.b * 1.5f
		);
	}

	void Update() {
		if (touching) {
			interval += Time.deltaTime;
			material.color = Color.Lerp(normalColor, highlightColor, interval);
		}

		if (Input.GetMouseButtonUp(0) && touching) {
			touching = false;
			material.color = normalColor;
		}
	}

	void OnMouseDown() {
		touching = true;
		interval = 0f;
	}
}
