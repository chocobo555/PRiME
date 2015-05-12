using UnityEngine;
using System.Collections;

public class DeathBOX : MonoBehaviour 
{
	public GameObject player;
	Vector3 startingPos;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.Find("OVRPlayerController");
	}


	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter()
	{
		startingPos = new Vector3(24, 2, 7);

		player.transform.position = startingPos;
		//Application.LoadLevel("scene1");
	}
}
