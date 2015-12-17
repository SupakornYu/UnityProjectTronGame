using UnityEngine;
using System.Collections;

public class checkgun : MonoBehaviour {
	float speed;

	Transform player1;
	Transform player2;
	GameObject gunplayer1;
	GameObject gunplayer2;
	
	// Use this for initialization
	void Start () {
		speed = 100.0f;
		gunplayer1 = GameObject.FindGameObjectWithTag ("gunplayer1");
		gunplayer2 = GameObject.FindGameObjectWithTag ("gunplayer2");

	}
	// Update is called once per frame
	void Update () {
		transform.Rotate(0.0f,speed*Time.deltaTime,0.0f);
		
	}
	void OnTriggerEnter(Collider obj)
	{
		if(obj.gameObject.CompareTag("Player1")){
			gunplayer1.gameObject.GetComponent<Shoot1>().Changegun();
			Destroy(gameObject);

		}else if(obj.gameObject.CompareTag("Player2")){
			gunplayer2.gameObject.GetComponent<Shoot2>().Changegun();
			Destroy(gameObject);

		}
	}
}
