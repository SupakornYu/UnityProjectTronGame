using UnityEngine;
using System.Collections;

public class Boomsound : MonoBehaviour {
	public AudioClip bombsound;
	AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void boomsound(){
		audioSource.clip = bombsound;
		audioSource.Play();

	}
}
