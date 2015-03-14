﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LockOn : MonoBehaviour 
{

	public KeyCode scan = KeyCode.E;
	GameObject scannerMonitor1;
	GameObject scannerMonitor2;
	Text scannedObject;

	[HideInInspector]
	public Vector3 fwd;


	// Use this for initialization
	void Start () 
	{
		scannerMonitor1 = GameObject.Find ("Scanner Monitor1");
		scannerMonitor2 = GameObject.Find ("Scanner Monitor2");

		//scannedObject = scannerMonitor1.GetComponent<Text>();
	}


	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown(scan)) 
		{
			fwd = transform.TransformDirection(Vector3.forward);
			RaycastHit hit;
			Physics.Raycast(transform.position, fwd, out hit, 10); 
			if (hit.collider != null) 
			{
				scannerMonitor1.GetComponent<Text>().text = hit.collider.gameObject.name;
				//scannedObject.text = hit.collider.gameObject.name;
				scannerMonitor2.GetComponent<Text>().text = hit.collider.gameObject.name;

				print(hit.collider.gameObject.name);
			}
		}
	

	}


}
