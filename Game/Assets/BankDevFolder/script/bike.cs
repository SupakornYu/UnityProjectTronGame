using UnityEngine;
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
	public GameObject impactsound;
	public GameObject effect1;
	public GameObject effect2;

	public GameObject effect1_slowItem;
	public GameObject effect2_slowItem;
	GameObject player1;
	GameObject player2;
	public GameObject pointChangeDirectionItem;

	public bool speedCheck2;
	public bool speedCheck1;
	public bool p1;
	public bool p2;
//	float timer;
//	float intervalTime;
	bool State;
	bool create;
	float timer;
	float intervalTime;

	float timer_speed;
	float intervalTime_speed;


	// Use this for initialization
	void Start () {
		speedCheck2 = false;
		speedCheck1 = false;
		create = false;
		State = false;
		speed = 8.0f;
		intervalTime = 6.0f;
		timer = intervalTime;

		intervalTime_speed = 5.0f;
		timer_speed = intervalTime_speed;

		p1 = false;
		p2 = false;
//		intervalTime = 1.0f;
//		timer = 0.0f;
		CreateLightCollider();
		SetColliderSize(wall,lastWallEnd,transform.position);

		initSetupSpeed ();

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


		//item slow
		//Debug.Log("speed p1 : " + GameObject.FindGameObjectWithTag("Player1").GetComponent<bike>().speed);
		//Debug.Log("speed p2 : " + GameObject.FindGameObjectWithTag("Player2").GetComponent<bike>().speed);
		if(speedCheck2 == true){
			//Debug.Log("timer : " + timer_speed);
			timer_speed = timer_speed - Time.deltaTime;
			if(timer_speed <= 0.0f){
				GameObject.FindGameObjectWithTag("Player1").GetComponent<bike>().speed += 5.0f;
				effect1_slowItem.SetActive(false);
				speedCheck2 = false;
				timer_speed = intervalTime_speed;
			}
		}else if(speedCheck1 == true){
			//Debug.Log("timer : " + timer_speed);
			timer_speed = timer_speed - Time.deltaTime;
			if(timer_speed <= 0.0f){
				GameObject.FindGameObjectWithTag("Player2").GetComponent<bike>().speed += 5.0f;
				effect2_slowItem.SetActive(false);
				speedCheck1 = false;
				timer_speed = intervalTime_speed;
			}
		}
		//end slow item


		// item change direction

		if (p2 == true) {
			timer = timer - Time.deltaTime;
			if(timer <= 0.0f){
				Debug.Log("player2 take");
				player1 = GameObject.FindGameObjectWithTag("Player1");
				player1.gameObject.GetComponent<bike>().left = KeyCode.A;
				player1.gameObject.GetComponent<bike>().right = KeyCode.D;
				effect1.SetActive(false);
				p2 = false;
				pointChangeDirectionItem.gameObject.GetComponent<spawnChangeDirectionItem>().bottleCheck = false;
				//Debug.Log ("done");
				timer = intervalTime;
			}
		}
		else if (p1 == true) {
			timer = timer - Time.deltaTime;
			if(timer <= 0.0f){
				Debug.Log("player1 take");
				player2 = GameObject.FindGameObjectWithTag("Player2");
				player2.gameObject.GetComponent<bike>().left = KeyCode.LeftArrow;
				player2.gameObject.GetComponent<bike>().right = KeyCode.RightArrow;
				effect2.SetActive(false);
				p1 = false;
				pointChangeDirectionItem.gameObject.GetComponent<spawnChangeDirectionItem>().bottleCheck = false;
				timer = intervalTime;
			}
		}
		// end item change direction
}
	void CreateLightCollider() {
		create = true;
		lastWallEnd = transform.position;
		GameObject g = (GameObject)Instantiate(wallPrefab, transform.position, Quaternion.identity);
		//g.name = "Wall";
		wall = g.GetComponent<Collider>();
	}
	void SetColliderSize(Collider col, Vector3 debut, Vector3 fin) {
		
		col.transform.position = debut + (fin - debut) * 0.5f;   
		float distance = Vector3.Distance(debut, fin);

			if (debut.x != fin.x)
				col.transform.localScale = new Vector3 (distance +0.175f, 1.0f, 0.1f);
			else
				col.transform.localScale = new Vector3 (0.1f, 1.0f, distance +0.175f);

	}
	void OnTriggerEnter(Collider col)
	{

		if(col.gameObject.CompareTag("Wall1") || col.gameObject.CompareTag("Wall2") )
		{
			//Time.timeScale = 0.3f;
			//Instantiate(boom, transform.position, Quaternion.identity);
			Instantiate(explosion,transform.position,transform.rotation);
			boomsound.GetComponent<Boomsound>().boomsound();
			//Destroy(gameObject);
			decreaseHealth(1,col);

		}else if (col.gameObject.CompareTag("Wallcheck"))
		{
			Instantiate(explosion,transform.position,transform.rotation);
			boomsound.GetComponent<Boomsound>().boomsound();
			//Destroy(gameObject);
			playerDie();

		}
	}
	public void check(){

		State = true;

	}
	public void impact(){

		impactsound.GetComponent<impactsound> ().impact ();

	}


	public void warp(Vector3 pos,Vector3 ro,Vector3 tran,float angleDegree){
		
		pos.y = transform.position.y;
		transform.Rotate(ro,angleDegree);
		transform.position = pos;
		transform.Translate (tran);
		CreateLightCollider ();
		
	}

	void decreaseHealth(int amount,Collider obj){
		if(gameObject.tag=="Player1"){

			GameSetting.Player1Health -= amount;
			Debug.Log("player1 :"+GameSetting.Player1Health);
			if(GameSetting.Player1Health<=0){
				playerDie();
			}else{
				Destroy(obj.gameObject);
			}

		}else if(gameObject.tag=="Player2"){

			GameSetting.Player2Health -= amount;
			Debug.Log("player2 :"+GameSetting.Player2Health);
			if(GameSetting.Player2Health<=0){
				playerDie();
			}else{
				Destroy(obj.gameObject);
			}
		}
	}

	void initSetupSpeed(){

		if(gameObject.tag=="Player1"){
			speed = GameSetting.Player1Speed ;
		}else if(gameObject.tag=="Player2"){
			speed = GameSetting.Player2Speed ;
		}

	}

	void playerDie(){
		Destroy(gameObject);
		if(gameObject.tag=="Player1"){
			GameSetting.Player1Health = 0;
			Debug.Log ("Player1 has passed away : " + GameSetting.Player1Health);
		}else if(gameObject.tag=="Player2"){
			GameSetting.Player2Health = 0;
			Debug.Log ("Player2 has passed away : " + GameSetting.Player2Health);
		}

		//Application.LoadLevel ("GameOverScence");
	}


}
