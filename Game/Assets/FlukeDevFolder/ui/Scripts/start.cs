using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class start : MonoBehaviour{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void changesceneStart(){
		Application.LoadLevel ("Player1");

	}
	public void changesceneRanking(){
		Application.LoadLevel ("Ranking");

	}
	public void changesceneCredit(){
		Application.LoadLevel ("Credit");

	}
	public void buttonEffect(){
		transform.Rotate (new Vector3 (0.0f, 1.0f, 0.0f), 45.0f);
	}

}
