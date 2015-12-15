using UnityEngine;
using System.Collections;

public class Power : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider obj){
		
		if(obj.gameObject.CompareTag("Player")){
			
			obj.GetComponent<PlayerHealth>().AddHealth(2);
			Destroy(gameObject);
		}
		
	}
}
