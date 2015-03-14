using UnityEngine;
using System.Collections;

public class VisionAlignment : MonoBehaviour 
{
	GameObject body;
	
	
	// Use this for initialization
	void Start () 
	{
		body = GameObject.Find("OVRPlayerController");
	}
	
	
	// Update is called once per frame
	void Update () 
	{
		
		transform.rotation = body.transform.rotation; // used to create alignment GUI
	
	}


}
