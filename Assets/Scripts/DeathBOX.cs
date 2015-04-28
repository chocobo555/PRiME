using UnityEngine;
using System.Collections;

public class DeathBOX : MonoBehaviour 
{



	// Use this for initialization
	void Start () 
	{
	
	}


	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter()
	{
		Application.LoadLevel("scene1");
	}
}
