using UnityEngine;
using System.Collections;

public class VisionCone : MonoBehaviour 
{
	public GameObject vision;
	public GameObject bodyDir;
	public float rotSpeed = 10;

	Quaternion tempRot;
	Vector3 tempPos;


	// Use this for initialization
	void Start () 
	{
	
	}

	
	// Update is called once per frame
	void Update () 
	{

		Vector3 tempVec = transform.localEulerAngles;// rotation;

		tempVec.z = vision.transform.localEulerAngles.y;// .rotation.y;

		tempPos = bodyDir.transform.position;

		tempVec.z *= -1;

		transform.localEulerAngles = tempVec;

		//transform.position = tempPos;
		//transform.localEulerAngles = Quaternion.Slerp(transform.rotation, tempRot, rotSpeed * Time.deltaTime); 







	}


}









