using UnityEngine;
using System.Collections;

public class TurnWithRift2 : MonoBehaviour 
{
	//public float turnSpeed = 60f;
	public float firstDegree = 5f;
	public float secondDegree = 10f;
	public float thirdDegree = 15f;
	public float fourthDegree = 20f;
	public float fifthDegree = 25f;
	
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
				 
				if (transform.localRotation.eulerAngles.y > 25 && transform.localRotation.eulerAngles.y <= 45) 
				{
					body.transform.Rotate(0, secondDegree * Time.deltaTime, 0);
				}

				if (transform.localRotation.eulerAngles.y > 45 && transform.localRotation.eulerAngles.y <= 65) 
				{
					body.transform.Rotate(0, thirdDegree * Time.deltaTime, 0);
				}

				if (transform.localRotation.eulerAngles.y > 65 && transform.localRotation.eulerAngles.y <= 85) 
				{
					body.transform.Rotate(0, fourthDegree * Time.deltaTime, 0);
				}
				
				if (transform.localRotation.eulerAngles.y > 85 && transform.localRotation.eulerAngles.y <= 105) 
				{
					body.transform.Rotate(0, fifthDegree * Time.deltaTime, 0);
				}
	
			}

			else if(enteredRadiusLeft == true)
			{

				if (transform.localRotation.eulerAngles.y <= 355 && transform.localRotation.eulerAngles.y >= 335) 
				{
					body.transform.Rotate(0, -firstDegree * Time.deltaTime, 0);
				}
				
				if (transform.localRotation.eulerAngles.y < 335 && transform.localRotation.eulerAngles.y >= 315) 
				{
					body.transform.Rotate(0, -secondDegree * Time.deltaTime, 0);
				}
				
				if (transform.localRotation.eulerAngles.y < 315 && transform.localRotation.eulerAngles.y >= 295) 
				{
					body.transform.Rotate(0, -thirdDegree * Time.deltaTime, 0);
				}
				
				if (transform.localRotation.eulerAngles.y < 295 && transform.localRotation.eulerAngles.y >= 275) 
				{
					body.transform.Rotate(0, -fourthDegree * Time.deltaTime, 0);
				}

				if (transform.localRotation.eulerAngles.y < 275 && transform.localRotation.eulerAngles.y >= 255) 
				{
					body.transform.Rotate(0, -fifthDegree * Time.deltaTime, 0);
				}
			}
			
		}
		
	}
}

