using UnityEngine;
using System.Collections;

public class back : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void goBack(){
		Application.LoadLevel ("startscene");
	}
}
