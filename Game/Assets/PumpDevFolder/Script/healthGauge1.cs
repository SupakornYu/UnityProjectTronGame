using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class healthGauge1 : MonoBehaviour {

	public Image HealthBar;
	public Text text_p;
	Text text_u;

	float p1Health;

	// Use this for initialization
	void Start () {
		p1Health = GameSetting.Player1Health;
		p1Health *= 0.25f;
		HealthBar.fillAmount = p1Health;
		text_u = text_p.GetComponent<Text>();
		text_u.text = p1Health+"";

	}
	
	// Update is called once per frame
	void Update () {
		p1Health = GameSetting.Player1Health;
		p1Health *= 0.25f;
		HealthBar.fillAmount = p1Health;
		text_u = text_p.GetComponent<Text>();
		text_u.text = GameSetting.Player1Health+"";
	}

	public void setZero(){

		HealthBar.fillAmount = 0;
		text_u.text = "0";
	}
}
