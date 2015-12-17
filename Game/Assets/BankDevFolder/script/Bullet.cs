using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	float startTime;
	float lifeTime;
	float timer;
	GameObject player1;
	GameObject player2;



	void Start(){

		lifeTime = 2.0f;
		startTime = Time.time;
		player1 = GameObject.FindGameObjectWithTag ("Player1");
		player2 = GameObject.FindGameObjectWithTag ("Player2");
		
	}
	void Update () {

		if(Time.time >= (startTime+lifeTime)){
			Destroy(gameObject);
		}
	}
	void OnTriggerEnter(Collider obj){
		if(obj.gameObject.CompareTag("Wall1"))
		{
			Destroy(obj.gameObject);
			Destroy(gameObject);
			if(player1!=null){
				player1.GetComponent<bike>().check();
				player1.GetComponent<bike>().impact ();
			}
		}else if(obj.gameObject.CompareTag("Wall2"))
		{
			Destroy(obj.gameObject);
			Destroy(gameObject);
			if(player2!=null){
				player2.GetComponent<bike>().check();
				player2.GetComponent<bike>().impact ();
			}
		}
		
	}
}


