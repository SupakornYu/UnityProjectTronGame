using UnityEngine;
using System.Collections;

public class bottle : MonoBehaviour {

	public GameObject axisPoint;
	GameObject player1;
	GameObject player2;
	//public GameObject effect1;
	//public GameObject effect2;



	float speed;
	// Use this for initialization
	void Start () {
		speed = 180.0f;
		player1 = GameObject.FindGameObjectWithTag ("Player1");
		player2 = GameObject.FindGameObjectWithTag ("Player2");
		//effect1 = GameObject.FindGameObjectWithTag ("ChangeDirectionEffect1");
		//effect2 = GameObject.FindGameObjectWithTag ("ChangeDirectionEffect2");

	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(axisPoint.transform.position,axisPoint.transform.up,speed*Time.deltaTime);
	}

	void OnTriggerEnter(Collider obj)
	{
		if(obj.gameObject.CompareTag("Player2")){

			player1.gameObject.GetComponent<bike>().left = KeyCode.D;
			player1.gameObject.GetComponent<bike>().right = KeyCode.A;
			player1.gameObject.GetComponent<bike>().p2 = true;
			player1.gameObject.GetComponent<bike>().effect1.SetActive(true);
			//effect1.SetActive(true);
			Destroy(gameObject);
			Debug.Log ("Player2");
			//effect1.SetActive(false);
			//Debug.Log ("p2 :"+ p2);


		}else if(obj.gameObject.CompareTag("Player1")){

			player2.gameObject.GetComponent<bike>().left = KeyCode.RightArrow;
			player2.gameObject.GetComponent<bike>().right = KeyCode.LeftArrow;
			player2.gameObject.GetComponent<bike>().p1 = true;
			player1.gameObject.GetComponent<bike>().effect2.SetActive(true);
			//effect2.SetActive(true);
			Destroy(gameObject);
			Debug.Log ("Player1");

		}
	}

}
