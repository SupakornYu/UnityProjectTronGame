using UnityEngine;
using System.Collections;

public class impactsound : MonoBehaviour {
	public AudioClip impactsounds;
	AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void impact(){
		audioSource.clip = impactsounds;
		audioSource.Play();

		
	}
}
