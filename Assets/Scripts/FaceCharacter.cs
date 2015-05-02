using UnityEngine;
using System.Collections;

public class FaceCharacter : MonoBehaviour 
{
	GameObject centerAnchor;



	// Use this for initialization
	void Start () 
	{
		centerAnchor = GameObject.Find("CenterEyeAnchor");
	}

	
	// Update is called once per frame
	void Update () 
	{
		transform.LookAt(centerAnchor.transform.position, -Vector3.up); 
	}
}
