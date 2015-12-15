using UnityEngine;
using System.Collections;

public class Shoot1 : MonoBehaviour
{

	public GameObject bullet;
	public float speed;
	public float type;
	float timer;
	float check;
	void start(){
		type = 1;
	}
	// Update is called once per frame
	void Update ()
	{

		shooting ();
		StartCoroutine("SpawnBall");

	}
	
	IEnumerator SpawnBall(){
		
		if (type <= 0) {
			yield return new WaitForSeconds(5);
			type = 1;
		}
	}
	
	public void Changegun(){
		
		type = 0;
	}
	
	public void shooting(){

		if (type > 0) {

		} else if (type <= 0 && Input.GetButtonDown ("Fire1")) {
			GameObject gunBullet = (GameObject)Instantiate(bullet,transform.position,transform.rotation);;
			gunBullet.GetComponent<Rigidbody>().velocity = transform.forward*-speed;
		}
	}
	
	
}