using UnityEngine;
using System.Collections;

public class showcycle : MonoBehaviour {
	float speed;

	// Use this for initialization
	void Start () {
		speed = 50.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0.0f, 0.0f, 1.0f), speed * Time.deltaTime);
	
	}
}
