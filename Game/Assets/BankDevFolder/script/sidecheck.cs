using UnityEngine;
using System.Collections;

public class sidecheck : MonoBehaviour {
	public GameObject thundereffect;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	void OnTriggerEnter(Collider obj){
		if(obj.gameObject.CompareTag("Wall"))
		{

			Instantiate(thundereffect,transform.position,transform.rotation);
		}
		
	}
}
