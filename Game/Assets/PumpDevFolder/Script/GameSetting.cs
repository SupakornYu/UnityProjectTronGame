﻿using UnityEngine;
using System.Collections;

public class GameSetting : MonoBehaviour {

	public static int Player1Health;
	public static int Player2Health;
	public static float Player1Speed;
	public static float Player2Speed;

	void Start () {
		
		Player1Health = 1;
		Player2Health = 1;

		Player1Speed = 8.0f;
		Player2Speed = 8.0f;

	}

}
