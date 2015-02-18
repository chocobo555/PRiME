using UnityEngine;
using System.Collections;

public class BodyFacingDirection : MonoBehaviour 
{
	public GameObject body;

	// Use this for initialization
	void Start () 
	{
		body = GameObject.Find("OVRPlayerController");
	}


	// Update is called once per frame
	void Update () 
	{
		Quaternion myTempRot = GetComponent<RectTransform>().localRotation;// .rotation;

		myTempRot.z = body.transform.rotation.y;

		myTempRot.z *= -1;

		//myTempRot.x = 0;
		Mathf.Clamp01(myTempRot.x);

		//myTempRot.y = 0;
		Mathf.Clamp01(myTempRot.y);

		GetComponent<RectTransform>().localRotation = myTempRot;



		//float bodyTempRot = body.transform.rotation.y;

		//transform.rotation.x = bodyTempRot;


		/*
		Vector3 pos = transform.position;
		pos.x = 4;
		transform.position = pos;
		*/
	}
}
