using UnityEngine;
using System.Collections;

public class Shoot1 : MonoBehaviour
{
	public GameObject bullet;
	public float speed;
	int type;
	float timer;
	float intervalTime;
	bool check;
	public GameObject shootsound;


	void Start(){
		check = false;
		intervalTime = 2.0f;
		timer = 0.0f;
		type = 1;

	}
	// Update is called once per frame
	void Update ()
	{
		

		if (type <= 0) {
			shooting ();
			timer = timer + Time.deltaTime;
			if(check){
				type = 0;
				timer = 0.0f;
				check = false;
				
			}if (timer >= intervalTime) {
				type = 1;
				timer = 0.0f;
			}
		}
//		StartCoroutine("SpawnBall");
		
	}
	
//	IEnumerator SpawnBall(){
//		
//		if (type <= 0) {
//
//			yield return new WaitForSeconds(5);
//
//			type = 1;
//		}
//	}
	
	public void Changegun(){
			type = 0;
		check = true;
	}
	
	public void shooting(){
		
		if (type > 0 ) {
			
		} else if (type <= 0 && Input.GetKey(KeyCode.W)) {
			GameObject gunBullet = (GameObject)Instantiate(bullet,transform.position,transform.rotation);
			gunBullet.GetComponent<Rigidbody>().velocity = transform.forward*-speed;
			shootsound.GetComponent<shootsound>().shoot();
		}
	}


	
}