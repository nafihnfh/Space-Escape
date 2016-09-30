using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UImanager : MonoBehaviour {
	public scoreui ob;

	public Text scoretext;
	public Text waittext;
	public int score;

	bool gameover;
	public Button[] buttons;
	public float timer=4f;

	// Use this for initialization
	void Start () {





		gameover = false;
		score = 0;
		InvokeRepeating ("scoreUpdate", 0f, 1.0f);




	}

	// Update is called once per frame
	void Update () {
		if (!gameover) {
			scoretext.text = "" + score;
		}
	}
	void scoreUpdate()
	{

		if (!gameover) {
			score += 1;

		}
	}
	

	public void gover()
	{


		gameover = true;

		int temp=PlayerPrefs.GetInt ("highscore");
		if (score > temp) {
			PlayerPrefs.SetInt("highscore",score);
		}
		PlayerPrefs.SetInt ("score",score );
		Application.LoadLevel ("over");
		Update();

	}

	public void play()
	{


	Application.LoadLevel ("countdown");


	}

	public void pause()
	{
		if (Time.timeScale == 1) {

			Time.timeScale=0;


		}
		else if (Time.timeScale == 0) {
			
			Time.timeScale=1;


		}

	}
	public void replay()
	{
		Application.LoadLevel (Application.loadedLevel);



	}
	public void menu()
	{

		Application.LoadLevel ("startmenu");



	}
	public void exit()
	{
		Application.Quit();

	}

}
