using UnityEngine;
using System.Collections;

public class warpGateController : MonoBehaviour {

	public GameObject destGate1;
	public float angleOut;
	public Vector3 tran;


	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnTriggerEnter(Collider obj){
		Debug.Log("trigger");

		if (obj.gameObject.CompareTag ("Player1") || obj.gameObject.CompareTag ("Player2")) {
			lanchPlayerWarp(destGate1,obj);
		}

	}

	void lanchPlayerWarp(GameObject tempGate,Collider obj){
		Vector3 destPo = tempGate.transform.position;
		obj.GetComponent<bike> ().warp (destPo, new Vector3 (1.0f, 0.0f, 0.0f),tran, angleOut);

	}
}
