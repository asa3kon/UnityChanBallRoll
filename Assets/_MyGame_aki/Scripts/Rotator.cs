﻿using UnityEngine;
using System.Collections;


public class Rotator : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (new Vector3 (10, 30, 45) * Time.deltaTime);
	}
}
