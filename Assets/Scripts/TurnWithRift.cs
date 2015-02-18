using UnityEngine;
using System.Collections;

public class TurnWithRift : MonoBehaviour 
{
	public float turnSpeed = 60f;

	public GameObject body;

	// Use this for initialization
	void Start () 
	{

		//body = GameObject.Find("OVRPlayerController");

	}


	// Update is called once per frame
	void Update () 
	{
		//print("non-local" + transform.rotation.eulerAngles.y);

		if (transform.rotation.eulerAngles.y > 45 && transform.rotation.eulerAngles.y < 315) 
		{
			print("reached turning angle");
			body.transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
		}
	}
}
