using UnityEngine;
using System.Collections;

public class Shoot2 : MonoBehaviour
{
	public GameObject bullet;
	public float speed;
	int type;
	float timer;
	float intervalTime;
	
	
	void Start(){
		intervalTime = 5.0f;
		timer = 0.0f;
		type = 1;
	}
	// Update is called once per frame
	void Update ()
	{
		
		
		if (type <= 0) {
			shooting ();
			timer = timer + Time.deltaTime;
			if (timer >= intervalTime) {
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
	}
	
	public void shooting(){
		
		if (type > 0 ) {
			
		} else if (type <= 0 && Input.GetKey(KeyCode.UpArrow)) {
			GameObject gunBullet = (GameObject)Instantiate(bullet,transform.position,transform.rotation);
			gunBullet.GetComponent<Rigidbody>().velocity = transform.forward*-speed;
		}
	}
	
	
	
}