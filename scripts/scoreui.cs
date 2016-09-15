using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scoreui : MonoBehaviour {
	public Text finalscore;
	public Text highscore;
	public int score;
	// Use this for initialization
	
	
	// Update is called once per frame
	public void Update () {

		score = PlayerPrefs.GetInt ("score");
		finalscore.text = ""+score;
		highscore.text = "HIGH SCORE: " + PlayerPrefs.GetInt ("highscore");
	}
}
