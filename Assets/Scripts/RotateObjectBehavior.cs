﻿using UnityEngine;
using System.Collections;
public class RotateObjectBehaviour : MonoBehaviour {

	private bool mIsRotated = false;
	private bool mMustRotate = false;

	private GameObject chipsTarget;

	// Use this for initialization
	void Start () {
		chipsTarget = GameObject.Find ("molec");
	}

	// Update is called once per frame
	void Update () {
		if (mMustRotate && !mIsRotated) {
			//Rotate all models 90 degrees around Y
			if (chipsTarget != null) {
				GameObject modelUnderChipsTrackable = chipsTarget.transform.GetChild(0).gameObject;
				modelUnderChipsTrackable.transform.RotateAround(new Vector3(0,1,0), Mathf.PI / 2);

			}
			mIsRotated = true;
			mMustRotate = false;
		}
	}

	void OnGUI() {
		if (GUI.Button(new Rect(0,0,100,50), "Rotate")) {
			if (!mIsRotated) {
				mMustRotate = true;
			}
		}
	}
}