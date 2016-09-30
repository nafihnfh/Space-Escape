using UnityEngine;
using System.Collections;

public class randomiser : MonoBehaviour {
	public GameObject[] planets;
	public float timedelay;
	 public float timer;
	int number;
	public GameObject instantiatedObj;
	// Use this for initialization
	void Start () {
		
		timer = timedelay;

	}

	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if (timer < 0) {
			Vector3 planetpos = new Vector3 (transform.position.x, Random.Range (-4.8f, 4.8f), transform.position.z);
			number=Random.Range(0,3);
			instantiatedObj=(GameObject)Instantiate (planets[number], planetpos, transform.rotation);
			Destroy(instantiatedObj,8f);
			timer=timedelay;
		}
	}
		
}	
