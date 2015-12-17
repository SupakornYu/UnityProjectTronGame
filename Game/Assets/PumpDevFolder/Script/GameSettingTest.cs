using UnityEngine;
using System.Collections;

public class GameSettingTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		StartCoroutine("SpawnBall",1.0f);

	}

	IEnumerator SpawnBall(float intervalTime){
		while(true){
			Debug.Log (GameSetting.Player1Health);
			GameSetting.Player1Health+=1;
			yield return new WaitForSeconds(intervalTime);
		}
	}


}
