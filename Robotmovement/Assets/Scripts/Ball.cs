using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision obj){
		
		if(obj.gameObject.CompareTag("Player")){
			obj.gameObject.GetComponent<PlayerHealth>().GetDamage(1);
			//Debug.Log("Hit !!");
			
		}
		
	}


}
