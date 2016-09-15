using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	bool  touchBegin=false;
	Vector2 initPos=new Vector2(0,0);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		int nbTouches = Input.touchCount;
		
		if(nbTouches > 0)
		{
			
			for (int i = 0; i < nbTouches; i++)
			{
				Touch touch = Input.GetTouch(i);

			}
		}
	}	
}
