using UnityEngine;
using System.Collections;

public class spawnSlowItem : MonoBehaviour {
	
	public GameObject obj;
	public GameObject ppp;
	
	float delayTime;
	public bool bottleCheck;
	
	
	void Start () {
		delayTime = 5.0f;
		StartCoroutine("spwanChangeDirectItem",delayTime);
		//bottleCheck = false;
		//StartCoroutine("spwanChangeDirectItem",delayTime);
	}
	IEnumerator spwanChangeDirectItem(float delayTime){
		if(bottleCheck == false){
			
			float offsetX = Random.Range(-30.0f,30.0f);
			float offsetZ = Random.Range(-30.0f,30.0f);
			Vector3 spawnPosition = new Vector3(ppp.transform.position.x+offsetX,ppp.transform.position.y,ppp.transform.position.z+offsetZ);
			Instantiate(obj,spawnPosition,Quaternion.identity);
			bottleCheck = true;
			yield return new WaitForSeconds(delayTime);
		}
	}
	void Update () {

	}
	
}