using UnityEngine;
using System.Collections;

public class rolling : MonoBehaviour {

	public Vector3 localScale;

	float timer;
	float intervalTime;
	float x;
	float y;
	float speed;

	// Use this for initialization
	void Start () {
		intervalTime = 0.05f;
		timer = 0.0f;
		x = 0.01f;
		y = 0.0f;
		speed = 1.0f;
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3(0.0f,1.0f,0.0f),100.0f*Time.deltaTime);
		transform.Translate(0.0f,speed*Time.deltaTime,speed*Time.deltaTime);

	
		timer = timer + Time.deltaTime;
		if(timer >= intervalTime){
			transform.localScale += new Vector3 (x, 0, 0);
			if(y == 10){
				x = -x;
				y = 0;
			}
			y += 1;
			timer = 0.0f;
		}
	}
}
