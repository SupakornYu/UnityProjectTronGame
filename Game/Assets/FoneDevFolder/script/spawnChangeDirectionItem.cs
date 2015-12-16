using UnityEngine;
using System.Collections;

public class spawnChangeDirectionItem : MonoBehaviour {

	public GameObject obj;
	public GameObject ppp;
	
	float delayTime;
	bool bottleCheck;
	
	
	void Start () {
		delayTime = 1.0f;
		bottleCheck = false;
		//StartCoroutine("spwanChangeDirectItem",delayTime);
	}
	IEnumerator spwanChangeDirectItem(float delayTime){
		if(bottleCheck == false){
			
			float offsetX = Random.Range(-25.0f,25.0f);
			float offsetZ = Random.Range(-25.0f,25.0f);
			Vector3 spawnPosition = new Vector3(ppp.transform.position.x+offsetX,ppp.transform.position.y,ppp.transform.position.z+offsetZ);
			Instantiate(obj,spawnPosition,Quaternion.identity);
			bottleCheck = true;
			yield return new WaitForSeconds(delayTime);
		}
	}
	void Update () {
		StartCoroutine("spwanChangeDirectItem",delayTime);
	}
	
}