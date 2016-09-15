using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class countdown : MonoBehaviour {
	public float timer;
	public Text  waittext;
	public int wait=0;
	bool started = false;
	// Use this for initialization
	void Start () {
	
	}
	void FixedUpdate()
	{
		

	}
	// Update is called once per frame
	void Update () {
		if (timer > 1) {
			timer -= Time.deltaTime;
			wait = (int)timer;
			waittext.text = "" + wait;
			
		} else if(!started) {
			play();
		}

	}

	void play()
	{

		Application.LoadLevel ("maingame");
		started = true;
	}


}
