using UnityEngine;
using System.Collections;

public class AudioMaster : MonoBehaviour 
{

	/*
	Make all audio sounds muffled. the only unmuffled is a constant breathing noise.
	this will also make finding a foot step noise i like easier.
	
	*/

	Movement myMovement;

	public AudioSource jumpAudioSource;
	public AudioClip jumpAudioClip;

	public AudioSource windAudioSource;
	public AudioClip windAudioClip;



	// Use this for initialization
	void Start () 
	{
		myMovement = GameObject.Find("OVRPlayerController").GetComponent<Movement>();

		jumpAudioSource = this.gameObject.AddComponent<AudioSource>();
		//windAudioSource = this.gameObject.AddComponent<AudioSource>();

		windAudioSource.clip = windAudioClip;

		//windAudioSource.Play();

	}


	public void JumpSound()
	{

		jumpAudioSource.clip = jumpAudioClip;
		jumpAudioSource.Play();

	}



	// Update is called once per frame
	void Update () 
	{
		windAudioSource.volume = myMovement.windVolume;

		print (windAudioSource.volume);
		

	}

}
