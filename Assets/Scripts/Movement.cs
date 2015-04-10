using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Movement : MonoBehaviour 
{
	public float groundSpeed = 6.0f;
	public float airSpeed = 3.0f;
	public float airDrift = 1f;

	public float jumpHeight = 5.0f;
	public float jumpLength = 1.0f;
	public float jumpForce = 1f;
	GameObject JumpForceSlider1;
	GameObject jumpForceSlider2;

	public float gravity = 20.0f;
	public float rotationSpeed;

	private CharacterController myController;
	private AudioMaster AM;

	[HideInInspector]
	public Vector3 moveDirection = Vector3.zero;



	// Use this for initialization
	void Start () 
	{
		myController = GetComponent<CharacterController>();
		JumpForceSlider1 = GameObject.Find("JumpForceSlider1");
		jumpForceSlider2 = GameObject.Find("JumpForceSlider2");
		AM = GameObject.Find("CenterEyeAnchor").GetComponent<AudioMaster>();

	}

	
	// Update is called once per frame
	void Update () 
	{
		/*
		float turn = Input.GetAxis("Horizontal");
		transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
		*/

		float scrollDirection = Input.GetAxis ("Mouse ScrollWheel");
		if (scrollDirection > 0) 
		{
			jumpForce = jumpForce + .5f;
		}
		if (scrollDirection < 0) 
		{
			jumpForce = jumpForce - .5f;
		}
		if (jumpForce < 1) 
		{
			jumpForce = 1;
		}
		if (jumpForce > 6) 
		{
			jumpForce = 6;
		}

		JumpForceSlider1.GetComponent<Slider>().value = jumpForce;
		jumpForceSlider2.GetComponent<Slider>().value = jumpForce;
		//print(jumpForce);

		float TempJumpHeight = jumpHeight * jumpForce;
		float TempJumpLength = jumpLength * jumpForce;


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

			AM.audioSource.Stop();

			if(Input.GetButton("Jump")) 
			{
				moveDirection *= TempJumpLength;
				moveDirection.y = TempJumpHeight;


				// *****************possible fix
				Vector3 tempvec = new Vector3();
				tempvec = Vector3.ClampMagnitude(tempvec, 10f);
				// ****************************

				//AM.JumpSound();

				print(jumpHeight);
			

			}
		}

		else 
		{
	
			// We are not grounded. We can still influence the movement with the horizontal and vertical axis, but not so strong.
			Vector3 tempVec = new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * airDrift, 0, Input.GetAxis("Vertical") * Time.deltaTime * airSpeed);
			moveDirection += transform.TransformDirection(tempVec);

			//moveDirection += transform.TransformDirection(Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * airDrift, 0, Input.GetAxis("Vertical") * Time.deltaTime * airSpeed));

		}

		moveDirection.y -= gravity * Time.deltaTime;
		myController.Move(moveDirection * Time.deltaTime);

		print(moveDirection);


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





