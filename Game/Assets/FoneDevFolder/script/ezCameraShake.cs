using UnityEngine;
using System.Collections;

public class ezCameraShake : MonoBehaviour {
	//GameObject cam;
	float a;
	float b;
	float c;
	bool FlagTog;
	float intervalTime;
	// Use this for initialization
	void Start () {

		FlagTog = true;
		intervalTime = 0.5f;
		StartCoroutine ("ToggleFlag");


	}

	IEnumerator ToggleFlag(){

		while(true){
			FlagTog = !FlagTog;
			yield return new WaitForSeconds(intervalTime);
		}

	}

	void shake(){
		gameObject.GetComponent<Camera> ().fieldOfView = Mathf.Lerp(gameObject.GetComponent<Camera> ().fieldOfView,50.0f,10.0f*Time.deltaTime);
	}

	void shakein(){
		gameObject.GetComponent<Camera> ().fieldOfView = Mathf.Lerp(gameObject.GetComponent<Camera> ().fieldOfView,40.0f,10.0f*Time.deltaTime);
	}

	void shakeout(){
		gameObject.GetComponent<Camera> ().fieldOfView = Mathf.Lerp(gameObject.GetComponent<Camera> ().fieldOfView,120.0f,10.0f*Time.deltaTime);
	}

	
	// Update is called once per frame
	void Update () {

		if (FlagTog) {
			shakein();
		} else {
			shakeout();
		}

	}
}
