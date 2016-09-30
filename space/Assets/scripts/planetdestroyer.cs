using UnityEngine;
using System.Collections;

public class planetdestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag=="Finish")
		{
			Destroy(col.gameObject);
	    }


    }
}