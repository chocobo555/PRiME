using UnityEngine;
using System.Collections;

public class BodyFacingDirection : MonoBehaviour 
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
		
		transform.rotation = body.transform.rotation;

		//******************************************************************

		/*
		Quaternion tempRot = transform.rotation;

		tempRot.x = 0;

		tempRot.y = 0;

		tempRot.z = body.transform.rotation.y;

		transform.rotation = tempRot;
		*/

		//*******************************************************************

		/*
		Vector3 tempVec = transform.localEulerAngles;// rotation;
		
		tempVec.z = body.transform.localEulerAngles.y;// .rotation.y;
		
		tempVec.z *= -1;
		
		transform.localEulerAngles = tempVec;
		*/

		//*******************************************************************

		/*
		Vector3 euler = transform.rotation.eulerAngles;
		Quaternion rot = Quaternion.Euler(0, 0, euler.y);
		transform.rotation = rot;
		*/

	}
}





