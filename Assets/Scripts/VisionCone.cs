using UnityEngine;
using System.Collections;

public class VisionCone : MonoBehaviour 
{
	public GameObject vision;


	// Use this for initialization
	void Start () 
	{
		//vision = GameObject.Find("LeftEyeAnchor");
	}

	
	// Update is called once per frame
	void Update () 
	{

		Quaternion myTempRot = GetComponent<RectTransform>().localRotation;// .rotation;
		
		//myTempRot.z = vision.transform.localRotation.eulerAngles.y;
		myTempRot.z = vision.transform.rotation.y;
		
		myTempRot.z *= -1;


		myTempRot.z = Mathf.Clamp(myTempRot.z, -45, 45); 
		//Mathf.Clamp(myTempRot.z, 0, 45);
		print(myTempRot.eulerAngles.z);


		//GetComponent<RectTransform>().rotation = myTempRot;


		/*
		if (transform.rotation.y > 45 && transform.rotation.y < 315) 
		{
			
			transform.Rotate(0, 0, vision.GetComponent<TurnWithRift>().turnSpeed * Time.deltaTime);

		}
		*/
	}


}









