using UnityEngine;
using System.Collections;

public class Walldestroyed : MonoBehaviour {
	public GameObject WallPaticiple;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider obj){
		if(obj.gameObject.CompareTag("Bullet"))
		{

			Destroy(gameObject);
			Instantiate(WallPaticiple,obj.transform.position,obj.transform.rotation);

			
		}
		
	}
}
