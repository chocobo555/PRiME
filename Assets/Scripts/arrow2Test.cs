﻿using UnityEngine;
using System.Collections;

public class arrow2Test : MonoBehaviour 
{
	GameObject body;

	public GameObject arrow1;
	
	
	// Use this for initialization
	void Start () 
	{
		body = GameObject.Find("OVRPlayerController");
	}

	
	// Update is called once per frame
	void Update () 
	{

		Vector3 tempVec = transform.localEulerAngles;// rotation;

		tempVec.z = arrow1.transform.localEulerAngles.y;// .rotation.y;
		
		tempVec.z *= -1;
		
		transform.localEulerAngles = tempVec;

	}
}
