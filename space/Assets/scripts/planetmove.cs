﻿	using UnityEngine;
using System.Collections;

public class planetmove : MonoBehaviour {
	public float speed=8f;
	public float rotatedirection;


	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

	
		transform.Translate (new Vector3 (-1, 0, 0) *speed* Time.deltaTime);

	}
}
 