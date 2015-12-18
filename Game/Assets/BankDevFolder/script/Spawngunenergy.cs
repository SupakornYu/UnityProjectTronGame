using UnityEngine;
using System.Collections;

public class Spawngunenergy : MonoBehaviour {
	
	public GameObject gunenegy;

	public float delayTime;

	
	void Start () {

		StartCoroutine("Spawnenemy",delayTime);
	}
	IEnumerator Spawnenemy(float delayTime){
		while(true){
			
			float offsetX = Random.Range(-50.0f,50.0f);
			float offsetZ = Random.Range(-50.0f,50.0f);
			Vector3 spawnPosition = new Vector3(transform.position.x+offsetX,transform.position.y,transform.position.z+offsetZ);
			Instantiate(gunenegy,spawnPosition,Quaternion.identity);
			yield return new WaitForSeconds(delayTime);
		}
	}
	void Update () {

	}

}
