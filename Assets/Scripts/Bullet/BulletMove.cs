﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

	public float bulletSpeed = 100f;
	void Start(){
		Destroy (gameObject, 3f);
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(0, bulletSpeed * Time.deltaTime, 0));
	}
}
