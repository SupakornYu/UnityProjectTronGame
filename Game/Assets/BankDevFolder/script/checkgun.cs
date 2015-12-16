using UnityEngine;
using System.Collections;

public class checkgun : MonoBehaviour {
	float speed;
	public GameObject gun1;
	public GameObject gun2;
	Transform player1;
	Transform player2;

	
	// Use this for initialization
	void Start () {
		speed = 100.0f;

	}
	// Update is called once per frame
	void Update () {
		transform.Rotate(0.0f,speed*Time.deltaTime,0.0f);
		
	}
	void OnTriggerEnter(Collider obj)
	{
		if(obj.gameObject.CompareTag("Player1")){
			Destroy(gameObject);
			gun1.gameObject.GetComponent<Shoot1>().Changegun();
		}else if(obj.gameObject.CompareTag("Player2")){
			Destroy(gameObject);
			gun2.gameObject.GetComponent<Shoot2>().Changegun();
		}
	}
}
