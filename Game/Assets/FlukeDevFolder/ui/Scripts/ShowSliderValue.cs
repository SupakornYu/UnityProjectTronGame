using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class ShowSliderValue : MonoBehaviour

{
	public void UpdateLabel (float value)
	{
		Text lbl = GetComponent<Text>();

		if (lbl != null) {
			lbl.text = Mathf.RoundToInt (value * 10)+".0";

		}


	}
	public void p1health(){
		Text temp = GetComponent<Text> ();
		float temp2 = float.Parse (temp.text);




	}
	public void p1speed(){
		Text temp = GetComponent<Text> ();
		float temp2 = float.Parse (temp.text);



	}
	public void p2health(){
		Text temp = GetComponent<Text> ();
		float temp2 = float.Parse (temp.text);



	}
	public void p2speed(){
		Text temp = GetComponent<Text> ();
		float temp2 = float.Parse (temp.text);



	}
}
