using UnityEngine;
using System.Collections;

public class slowItem : MonoBehaviour {
	//GameObject player;

	//public GameObject effect1_slowItem;
	//public GameObject effect2_slowItem;
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
			GameObject.FindGameObjectWithTag("Player1").GetComponent<bike>().effect1_slowItem.SetActive(true);
			Destroy(gameObject);
			//obj.gameObject.GetComponent<bike>().p2 = true;
			//effect1.SetActive(true);
			//effect1.SetActive(false);
			//Debug.Log ("p2 :"+ p2);
			
			
		}else if(obj.gameObject.CompareTag("Player1")){
			GameObject.FindGameObjectWithTag("Player2").GetComponent<bike>().speed -= 5.0f;
			obj.gameObject.GetComponent<bike>().speedCheck1 = true;
			GameObject.FindGameObjectWithTag("Player2").GetComponent<bike>().effect2_slowItem.SetActive(true);
			Destroy(gameObject);
			//obj.gameObject.GetComponent<bike>().p1 = true;
			//effect2.SetActive(true);
			
			
		}
	}
}
