using UnityEngine;
using System.Collections;

public class TurnWithRift : MonoBehaviour 
{
	public float turnSpeed = 60f;

	public GameObject body;

	bool enteredRadiusRight = false;
	bool enteredRadiusLeft = false;


	// Use this for initialization
	void Start () 
	{

		//body = GameObject.Find("OVRPlayerController");

	}


	// Update is called once per frame
	void Update () 
	{
		//print(transform.localRotation.eulerAngles.y);

		if (transform.localRotation.eulerAngles.y > 45 && transform.localRotation.eulerAngles.y < 50) 
		{

			enteredRadiusRight = true;
			enteredRadiusLeft = false;

		}

		if(transform.localRotation.eulerAngles.y < 315 && transform.localRotation.eulerAngles.y > 310)
		{
		
			enteredRadiusLeft = true;
			enteredRadiusRight = false;

		}

		if(transform.localRotation.eulerAngles.y > 45 && transform.localRotation.eulerAngles.y < 315) 
		{
			//print("angle reached");

			if (enteredRadiusRight == true) 
			{
//				print ("over 45");
				body.transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
			}
			else if(enteredRadiusLeft == true)
			{
//				print ("under 315");
				body.transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
			}

		}

	}
}
