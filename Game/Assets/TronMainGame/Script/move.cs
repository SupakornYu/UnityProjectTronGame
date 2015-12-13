using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {


	float speed;
	
	// Use this for initialization
	void Start () {
		speed = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(speed*Time.deltaTime,speed*Time.deltaTime,0.0f);
	}
}
