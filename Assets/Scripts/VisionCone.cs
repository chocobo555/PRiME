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
	
	}

	
	// Update is called once per frame
	void Update () 
	{

		tempRot = transform.rotation;

		tempRot.z = vision.transform.rotation.y;
		tempRot.z = Mathf.Clamp(tempRot.z, -45, 45);

		tempRot.z *= -1;

		transform.rotation = Quaternion.Slerp(transform.rotation, tempRot, rotSpeed * Time.deltaTime); 

	}


}









