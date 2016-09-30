using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class rcontrol : MonoBehaviour {

	public UImanager ob;



	public float speed;
	public float minpos;
	public float maxpos;
	public Vector3 position;
	public GameObject explosion;
	public float cangle;
	
	bool  touchBegin=false;
	Vector2 initPos=new Vector2(0,0);
	Vector2 initrotate=new Vector2(0,0);
	public float a,b,c,d,s,h,bs,al; 
	public float angle;
	public float tempangle;
	public float diff;
	bool rotationflag = true;
	
	float  rad;
	const float deg=180.0f/3.14f;
	
			
	// Use this for initialization
	void Start () {
		//ob=GetComponent(UImanager>();
	
		position = transform.position;
		s=Screen.width;
		h = Screen.height;
		h = h / 2;
		h = h / 60;

		transform.position = new Vector3 (-1.83f,0,0);
		

		//Debug.Log (s);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0) {//touch started;
			if (touchBegin == false) {

				initPos = new Vector2 (Input.GetTouch (0).position.x, Input.GetTouch (0).position.y);


				float f=initPos.x;
				float h=initrotate.x;
				Debug.Log(h);
				touchBegin = true;
				
			} 

			else 

			{

				//this.transform.Rotate(0f,0f,-Mathf.Clamp(angle,-60f,60f)*Time.fixedDeltaTime*5);
				if(Input.GetTouch(0).position.x>=(s/2))
				{
					if(Input.GetTouch(1).position.x<=(s/2))
					{
					 
						b = (int)(Input.GetTouch (0).position.y - initPos.y);
						Vector3 temp = transform.position; 
						bs = this.transform.position.x - initPos.x;
						al = Input.GetTouch (1).position.y - initPos.y;
						rad = Mathf.Atan (al / bs);
						Debug.Log (deg * rad);
						float p = deg * rad;
						temp.y  = Mathf.Clamp(b*2*Time.fixedDeltaTime, -4.1f, 4.1f);
						transform.position=	temp;
						if(Input.GetTouch(1).position.x>=(s/2)||Input.GetTouch(0).position.x>=(s/2))
						this.transform.eulerAngles = new Vector3(0,0,p*4);
					   

					}

				}
				else  if(Input.GetTouch(0).position.x<=(s/2))
				{
					if(Input.GetTouch(1).position.x>=(s/2))
					{
						b = (int)(Input.GetTouch (1).position.y - initPos.y);
						Vector3 temp = transform.position; 
						bs = this.transform.position.x - initPos.x;
						al = Input.GetTouch (0).position.y - initPos.y;
						rad = Mathf.Atan (al / bs);
						Debug.Log (deg * rad);
						float p = deg * rad;
						temp.y  = Mathf.Clamp(b*2*Time.fixedDeltaTime, -4.1f, 4.1f);
						if(Input.GetTouch(1).position.x>=(s/2)||Input.GetTouch(0).position.x>=(s/2))
							this.transform.eulerAngles = new Vector3(0,0,p*2f);
						transform.position=	temp;
						
					}
				}
			

				



			}
				
						
		}
	}
		void OnCollisionEnter2D(Collision2D col)
				{


					if (col.gameObject.tag == "obstacle") 
					{
					Destroy (gameObject);
			        ob.gover();

					}

	
				}
				
}