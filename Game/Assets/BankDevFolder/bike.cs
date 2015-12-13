using UnityEngine;
using System.Collections;


public class bike : MonoBehaviour {
	public float speed = 5.0f;
	public GameObject wallPrefab;
	private Collider wall;
	private Vector3 lastWallEnd;
	public KeyCode left;
	public KeyCode right;
	public GameObject boom;


	// Use this for initialization
	void Start () {
		CreateLightCollider();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * speed * Time.deltaTime);

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
		g.name = "Wall";
		wall = g.GetComponent<Collider>();
	}
	void SetColliderSize(Collider col, Vector3 debut, Vector3 fin) {
		
		col.transform.position = debut + (fin - debut) * 0.5f;   
		float distance = Vector3.Distance(debut, fin);
		
		if (debut.x != fin.x)
			col.transform.localScale = new Vector3(distance , 0.1f, 0.1f);
		else
			col.transform.localScale = new Vector3(0.1f	, 0.1f, distance );
	}
	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.name == "Wall")
		{
			Time.timeScale = 0.3f;
			//Instantiate(boom, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}



}
