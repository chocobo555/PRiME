using UnityEngine;
using System.Collections;

public class AudioMaster : MonoBehaviour 
{

	/*
	Make all audio sounds muffled. the only unmuffled is a constant breathing noise.
	this will also make finding a foot step noise i like easier.
	
	*/

	public AudioSource audioSource;
	public AudioClip jumpAudioClip;



	// Use this for initialization
	void Start () 
	{
		audioSource = this.gameObject.AddComponent<AudioSource>();
	}


	public void JumpSound()
	{

		audioSource.clip = jumpAudioClip;
		audioSource.Play();

	}


	// Update is called once per frame
	void Update () 
	{
		
	}

}
