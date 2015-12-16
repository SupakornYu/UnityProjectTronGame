﻿using UnityEngine;
using System.Collections;


public class bike : MonoBehaviour {
	public float speed;
	public GameObject wallPrefab;
	private Collider wall;
	private Vector3 lastWallEnd;
	public KeyCode left;
	public KeyCode right;
    public GameObject explosion;
	public GameObject boomsound;
//	float timer;
//	float intervalTime;
	bool State;


	// Use this for initialization
	void Start () {
		State = false;
		speed = 8.0f;
//		intervalTime = 1.0f;
//		timer = 0.0f;
		CreateLightCollider();
		SetColliderSize(wall,lastWallEnd,transform.position);

	}
	
	// Update is called once per frame
	void Update () {

		//DynamicGI.UpdateMaterials(gameObject.renderer);
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
//		timer = timer + Time.deltaTime;
//		if (timer >= intervalTime) {
//
//			CreateLightCollider ();
//			timer = 0.0f;
//		}
		if (State) {
			CreateLightCollider();
			State = false;
		}

		if(Input.GetKeyUp(left))
		{
			this.transform.Rotate(new Vector3(-90,0,0));
			CreateLightCollider();
		}
		if(Input.GetKeyUp(right))
		{

			this.transform.Rotate(new Vector3(90,0,0));
			CreateLightCollider();
		}

		SetColliderSize(wall,lastWallEnd,transform.position);
}
	void CreateLightCollider() {
		lastWallEnd = transform.position;
		GameObject g = (GameObject)Instantiate(wallPrefab, transform.position, Quaternion.identity);
		//g.name = "Wall";
		wall = g.GetComponent<Collider>();
	}
	void SetColliderSize(Collider col, Vector3 debut, Vector3 fin) {
		
		col.transform.position = debut + (fin - debut) * 0.5f;   
		float distance = Vector3.Distance(debut, fin);

			if (debut.x != fin.x)
				col.transform.localScale = new Vector3 (distance + 0.5f, 1.0f, 0.5f);
			else
				col.transform.localScale = new Vector3 (0.5f, 1.0f, distance + 0.5f);

	}
	void OnTriggerEnter(Collider col)
	{

		if(col.gameObject.CompareTag("Wall1") || col.gameObject.CompareTag("Wall2") )
		{
			//Time.timeScale = 0.3f;
			//Instantiate(boom, transform.position, Quaternion.identity);
			Instantiate(explosion,transform.position,transform.rotation);
			boomsound.GetComponent<Boomsound>().boomsound();
			Destroy(gameObject);

		}else if (col.gameObject.CompareTag("Wallcheck"))
		{
			int x = Random.Range(1,3);

			if(x==1){


			this.transform.Rotate(new Vector3(90,0,0));
//				Debug.Log("right");
			CreateLightCollider();
			}else{
//				Debug.Log("left");
			this.transform.Rotate(new Vector3(-90,0,0));
			CreateLightCollider();
			}

		}
	}
	public void check(){

		State = true;

	}





}
