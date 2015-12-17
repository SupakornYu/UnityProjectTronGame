using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class ShowSliderValue : MonoBehaviour

{
	
	public void UpdateLabelspeed1 (float value)
	{
		Text lbl = GetComponent<Text>();

		if (lbl != null) {
			int temp = Mathf.RoundToInt (value * 10);
			lbl.text = Mathf.RoundToInt (value * 10)+".0";
			GameSetting.Player1Speed = temp;

		}



	}

	public void UpdateLabelhealth1 (float value)
	{
		Text lbl = GetComponent<Text>();

		if (lbl != null) {
			lbl.text = Mathf.RoundToInt (value*3)+".0";
			int temp = Mathf.RoundToInt (value * 3);
			if (temp >= 3) {
				
				GameObject.FindGameObjectWithTag ("speedsliderp1").GetComponent<Slider> ().maxValue = 0.5f;
				//GetComponent<Slider> ().value = 100.0f;
			} else if (temp >= 2) {
				GameObject.FindGameObjectWithTag ("speedsliderp1").GetComponent<Slider> ().maxValue = 1.0f;
				
			} else if(temp >= 1){
				GameObject.FindGameObjectWithTag ("speedsliderp1").GetComponent<Slider> ().maxValue = 1.5f;
				
			}else {
				GameObject.FindGameObjectWithTag ("speedsliderp1").GetComponent<Slider> ().maxValue = 2.0f;

			}
			GameSetting.Player1Health += temp;

		}


	}
	public void UpdateLabelspeed2 (float value)
	{
		Text lbl = GetComponent<Text>();

		if (lbl != null) {
			int temp = Mathf.RoundToInt (value * 10);
			lbl.text = Mathf.RoundToInt (value * 10)+".0";
			GameSetting.Player2Speed = temp;

		}



	}

	public void UpdateLabelhealth2 (float value)
	{
		Text lbl = GetComponent<Text>();

		if (lbl != null) {
			lbl.text = Mathf.RoundToInt (value*3)+".0";
			int temp = Mathf.RoundToInt (value * 3);
			if (temp >= 3) {

				GameObject.FindGameObjectWithTag ("speedsliderp1").GetComponent<Slider> ().maxValue = 0.5f;
				//GetComponent<Slider> ().value = 100.0f;
			} else if (temp >= 2) {
				GameObject.FindGameObjectWithTag ("speedsliderp1").GetComponent<Slider> ().maxValue = 1.0f;

			} else if(temp >= 1){
				GameObject.FindGameObjectWithTag ("speedsliderp1").GetComponent<Slider> ().maxValue = 1.5f;

			}else {
				GameObject.FindGameObjectWithTag ("speedsliderp1").GetComponent<Slider> ().maxValue = 2.0f;

			}
			GameSetting.Player2Health += temp;

		}


	}
//	public void p1health(){
//		Text temp = GetComponent<Text> ();
//		int temp2 = int.Parse (temp.text);
//
//		//GameSetting.Player1Health += temp;
//
//
//
//	}
//	public void p1speed(){
//		Text temp = GetComponent<Text> ();
//		float temp2 = float.Parse (temp.text);
//		print (GameSetting.Player1Speed);
//
//
//
//	}
//	public void p2health(){
//		Text temp = GetComponent<Text> ();
//		int temp2 = int.Parse (temp.text);
//		//GameSetting.Player2Health += temp;
//
//
//	}
//	public void p2speed(){
//		Text temp = GetComponent<Text> ();
//		float temp2 = float.Parse (temp.text);
//		//GameSetting.Player2Speed += temp;
//
//
//	}
}
