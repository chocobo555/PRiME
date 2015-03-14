using UnityEngine;
using System.Collections;

public class BodyFacingDirection : MonoBehaviour 
{
	GameObject body;

	GameObject lineOfSight;


	// Use this for initialization
	void Start () 
	{
		body = GameObject.Find("OVRPlayerController");

		lineOfSight = GameObject.Find("Line of Sight");
	}


	// Update is called once per frame
	void Update () 
	{

		Vector3 currentAngleOfSight = lineOfSight.transform.eulerAngles;

		Vector3 zeroAngleOfSight = body.transform.localEulerAngles;

		float angleOfDeviation = zeroAngleOfSight.y - currentAngleOfSight.y;

		if (angleOfDeviation < 0) 
		{
			angleOfDeviation *= -1;
		}

		if (angleOfDeviation > 180) 
		{
			float tempFloat = 360 - angleOfDeviation;

			angleOfDeviation = tempFloat;
		}

		print(angleOfDeviation);


		transform.rotation = body.transform.rotation; // used to create alignment GUI


		//***************************old shite***************************************

		/*
		Vector3 tempRot = transform.localEulerAngles;

		tempRot.z = zeroAngleOfSight.y;

		tempRot.z += 180;

		transform.localEulerAngles = tempRot;

		*/
		//***************************old shite****************************************

		/*
		Vector3 tempVec = transform.localEulerAngles;// rotation;
		
		tempVec.z = body.transform.localEulerAngles.y;// .rotation.y;
		
		tempVec.z *= -1;
		
		transform.localEulerAngles = tempVec;
		*/

		//*****************************old shite**************************************

		/*
		Vector3 euler = transform.rotation.eulerAngles;
		Quaternion rot = Quaternion.Euler(0, 0, euler.y);
		transform.rotation = rot;
		*/

	}
}





