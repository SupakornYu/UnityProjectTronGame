using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class healthGauge2 : MonoBehaviour {

	public Image HealthBar;
	public Text text_p;
	Text text_u;
	
	float p2Health;
	
	// Use this for initialization
	void Start () {
		p2Health = GameSetting.Player2Health;
		p2Health *= 0.25f;
		HealthBar.fillAmount = p2Health;
		text_u = text_p.GetComponent<Text>();
		text_u.text = p2Health+"";
		
	}
	
	// Update is called once per frame
	void Update () {
		p2Health = GameSetting.Player2Health;
		p2Health *= 0.25f;
		HealthBar.fillAmount = p2Health;
		text_u = text_p.GetComponent<Text>();
		text_u.text = GameSetting.Player2Health+"";
	}
	
	public void setZero(){
		
		HealthBar.fillAmount = 0;
		text_u.text = "0";
	}

}
