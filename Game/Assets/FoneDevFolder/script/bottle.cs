using UnityEngine;
using System.Collections;

public class bottle : MonoBehaviour {

	public GameObject axisPoint;
	public GameObject player1;
	public GameObject player2;
	public GameObject effect1;
	public GameObject effect2;



	float speed;
	// Use this for initialization
	void Start () {
		speed = 180.0f;

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
			effect1.SetActive(true);
			Destroy(gameObject);
			//effect1.SetActive(false);
			//Debug.Log ("p2 :"+ p2);


		}else if(obj.gameObject.CompareTag("Player1")){

			player2.gameObject.GetComponent<bike>().left = KeyCode.RightArrow;
			player2.gameObject.GetComponent<bike>().right = KeyCode.LeftArrow;
			player2.gameObject.GetComponent<bike>().p1 = true;
			effect2.SetActive(true);
			Destroy(gameObject);

		}
	}

}
