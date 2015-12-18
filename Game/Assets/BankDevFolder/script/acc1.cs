using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class acc1 : MonoBehaviour {
	bool checkspeed;
	float acc;
	float speed;
	float fillAmount;
	public Image AccBar;
	public Text text_p;
	Text text_u;
	float Percen;




	// Use this for initialization
	void Start () {
		text_u = text_p.GetComponent<Text>();
		fillAmount = AccBar.fillAmount;
		Percen = fillAmount * 100;
		text_u.text = fillAmount * 100+"";
		//Percen = float.Parse (text_p.text);
		Debug.Log (!Input.GetKey (KeyCode.Space));

		}
	
	// Update is called once per frame
	void Update () {
		Percen = fillAmount * 100;
		if (Input.GetKey (KeyCode.Space) && AccBar.fillAmount > 0.0f) {
			Debug.Log ("in");
			GameObject.FindGameObjectWithTag ("Player1").GetComponent<bike> ().speed = 15.0f;
			Debug.Log ("accbar :" + AccBar.fillAmount);
			Debug.Log ("speed  :" + GameObject.FindGameObjectWithTag ("Player1").GetComponent<bike> ().speed);
			fillAmount -= 0.5f * Time.deltaTime;
			Percen = fillAmount * 100;
			AccBar.fillAmount = fillAmount;
			text_u.text = fillAmount * 100 + "";
		} else if ((!Input.GetKey (KeyCode.Space)) && AccBar.fillAmount < 1.0f) {
			//Debug.Log("out");
			GameObject.FindGameObjectWithTag ("Player1").GetComponent<bike> ().speed = 8.0f;
			//Debug.Log("speed out :"+ GameObject.FindGameObjectWithTag ("Player1").GetComponent<bike> ().speed);
			fillAmount += GameSetting.Player1Speed * Time.deltaTime; 
			AccBar.fillAmount = fillAmount;
			Percen = fillAmount * 100;
			text_u.text = fillAmount * 100 + "";
		} else {
			GameObject.FindGameObjectWithTag ("Player1").GetComponent<bike> ().speed = 8.0f;
			AccBar.fillAmount = fillAmount;
		}

	}

}
