using UnityEngine;
using System.Collections;

public class VisionCone : MonoBehaviour 
{
	public GameObject vision;
	public float rotSpeed = 10;

	Quaternion tempRot;


	// Use this for initialization
	void Start () 
	{
		//vision = GameObject.Find("LeftEyeAnchor");
	}

	
	// Update is called once per frame
	void Update () 
	{
	
		/*
		Quaternion myTempRot = Quaternion.identity;
		myTempRot.eulerAngles = GetComponent<RectTransform>().eulerAngles; // localRotation;// .rotation;

		//myTempRot.z = vision.transform.localRotation.eulerAngles.y;
		myTempRot.z = vision.transform.eulerAngles.y;
		myTempRot.z *= -1;


		//myTempRot.z = Mathf.Clamp(myTempRot.z, -45, 45); 
		//Mathf.Clamp(myTempRot.z, 0, 45);
		print(myTempRot.eulerAngles.z);

		GetComponent<RectTransform>().eulerAngles = myTempRot.eulerAngles;
		*/



		//Quaternion rotation;

		//Vector3 myTempPos = vision.transform.position;

		//myTempPos.z = vision.transform.position.y;

		//rotation = Quaternion.LookRotation(myTempPos);

		tempRot = transform.rotation;

		tempRot.z = vision.transform.rotation.y;
		tempRot.z *= -1;


		transform.rotation = Quaternion.Slerp(transform.rotation, tempRot, rotSpeed * Time.deltaTime); 


		/*
		Vector3 pos = transform.position - target.transform.position;
		pos.x = transform.position.x;
		rotation = Quaternion.LookRotation(pos);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, rotSpeed * Time.deltaTime);
		*/
	}


	void LateUpdate()
	{

		float clampedZ = 0;

		if (transform.eulerAngles.z < 180) 
		{
			clampedZ = Mathf.Clamp(transform.eulerAngles.z , 0f, 45f);
		}
		else 
		{
			clampedZ = Mathf.Clamp(transform.eulerAngles.z , 315f, 359f);
		}


		transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y , clampedZ); 
	}
	

}









