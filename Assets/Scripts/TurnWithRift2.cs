using UnityEngine;
using System.Collections;

public class TurnWithRift2 : MonoBehaviour 
{
	//public float turnSpeed = 60f;
	public float firstDegree = 5f;
	
	public GameObject body;
	
	bool enteredRadiusRight = false;
	bool enteredRadiusLeft = false;

	
	// Use this for initialization
	void Start () 
	{
	
	}

	
	// Update is called once per frame
	void Update () 
	{
		//print(transform.localRotation.eulerAngles.y);
		
		if (transform.localRotation.eulerAngles.y > 5 && transform.localRotation.eulerAngles.y < 10) 
		{
			
			enteredRadiusRight = true;
			enteredRadiusLeft = false;
			
		}
		
		if(transform.localRotation.eulerAngles.y < 355 && transform.localRotation.eulerAngles.y > 350)
		{
			
			enteredRadiusLeft = true;
			enteredRadiusRight = false;
			
		}
		
		if(transform.localRotation.eulerAngles.y > 5 && transform.localRotation.eulerAngles.y < 355) 
		{
			//print("angle reached");
			
			if (enteredRadiusRight == true) 
			{
			
				if (transform.localRotation.eulerAngles.y >= 5 && transform.localRotation.eulerAngles.y <= 25) 
				{
					body.transform.Rotate(0, firstDegree * Time.deltaTime, 0);
				}
				 
				if (transform.localRotation.eulerAngles.y <= 5) 
				{

				}
	
			}
			else if(enteredRadiusLeft == true)
			{
				//	print ("under 315");
				body.transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);

			}
			
		}
		
	}
}

