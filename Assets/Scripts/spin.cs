﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class spin : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime*90);
	}
}
