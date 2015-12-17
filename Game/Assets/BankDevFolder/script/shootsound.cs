using UnityEngine;
using System.Collections;

public class shootsound : MonoBehaviour {
	public AudioClip shootsounds;
	AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void shoot(){
		audioSource.clip = shootsounds;
		audioSource.Play();
		
	}
}
