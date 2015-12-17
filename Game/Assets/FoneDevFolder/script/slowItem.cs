using UnityEngine;
using System.Collections;

public class slowItem : MonoBehaviour {
	//GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider obj)
	{
		if(obj.gameObject.CompareTag("Player2")){
			GameObject.FindGameObjectWithTag("Player1").GetComponent<bike>().speed -= 5.0f;
			obj.gameObject.GetComponent<bike>().speedCheck2 = true;
			Destroy(gameObject);
			//obj.gameObject.GetComponent<bike>().p2 = true;
			//effect1.SetActive(true);
			//effect1.SetActive(false);
			//Debug.Log ("p2 :"+ p2);
			
			
		}else if(obj.gameObject.CompareTag("Player1")){
			Destroy(gameObject);
			GameObject.FindGameObjectWithTag("Player2").GetComponent<bike>().speed -= 5.0f;
			obj.gameObject.GetComponent<bike>().speedCheck1 = true;
			//obj.gameObject.GetComponent<bike>().p1 = true;
			//effect2.SetActive(true);
			
			
		}
	}
}
