using UnityEngine;
using System.Collections;
public class background : MonoBehaviour {
	
	public float speed = 0.1f;
	bool f = false;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		
		Vector2 offset = new Vector2 (Time.time * speed, 0);
		GetComponent<Renderer> ().material.mainTextureOffset = offset;
		
	}
}
