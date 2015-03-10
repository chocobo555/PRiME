using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour 
{
	public float groundSpeed = 6.0f;
	public float jumpSpeed = 8.0f;
	public float gravity = 20.0f;
	public float rotationSpeed;

	private CharacterController myController;
	//private KeyCode walkForwardKey = KeyCode.W;
	[HideInInspector]
	public Vector3 moveDirection = Vector3.zero;


	// Use this for initialization
	void Start () 
	{
		myController = GetComponent<CharacterController>();
	}

	
	// Update is called once per frame
	void Update () 
	{
		/*
		float turn = Input.GetAxis("Horizontal");
		transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
		*/

		if(myController.isGrounded == true) 
		{
			// older
			/*
			moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			*/

			//older
			//moveDirection = transform.forward * Input.GetAxis("Vertical");
			//moveDirection = transform.right * Input.GetAxis("Horizontal");

			//current
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);


			moveDirection *= groundSpeed;

			if(Input.GetButton("Jump")) 
			{
				moveDirection.y = jumpSpeed;
			}
		}

		moveDirection.y -= gravity * Time.deltaTime;
		myController.Move(moveDirection * Time.deltaTime);


		/*
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;
		rotation *= Time.deltaTime;
		transform.Rotate(0, rotation, 0);
		*/


	}


	void FixedUpdate()
	{
		/*
		if (Input.GetKey(walkForwardKey)) 
		{
			rigidbody.AddForce(Vector3.forward * groundSpeed, ForceMode.Acceleration);
		}
		*/

	}


}







