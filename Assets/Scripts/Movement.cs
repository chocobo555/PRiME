using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Movement : MonoBehaviour 
{
	private float groundSpeed = 3.0f;
	private float airSpeed = 3.0f;
	private float airDrift = 1f;

	private float jumpHeight = 11f;
	private float jumpLength = 1.3f;

	private float jumpForce = 1f;
	private float sprintForce = 5;

	GameObject JumpForceSlider1;
	GameObject JumpForceSlider2;
	GameObject SprintForceSlider1;
	GameObject SprintForceSlider2;

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
		JumpForceSlider2 = GameObject.Find("JumpForceSlider2");
		SprintForceSlider1 = GameObject.Find("SprintForceSlider1");
		SprintForceSlider2 = GameObject.Find("SprintForceSlider2");

		AM = GameObject.Find("CenterEyeAnchor").GetComponent<AudioMaster>();

	}

	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown(KeyCode.Keypad3))
			jumpForce++;

		if (Input.GetKeyDown(KeyCode.Keypad1)) 
			jumpForce--;

		if (jumpForce < 1) 
			jumpForce = 1;
	
		if (jumpForce > 4) 
			jumpForce = 4;

		/*
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
		*/

		JumpForceSlider1.GetComponent<Slider>().value = jumpForce;
//		JumpForceSlider2.GetComponent<Slider>().value = jumpForce;
		//print(jumpForce);

		float TempJumpHeight = jumpHeight * (jumpForce / 2);
		float TempJumpLength = jumpLength * (jumpForce / 2);


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
		

			if(Input.GetKeyDown(KeyCode.Keypad6))
				sprintForce = sprintForce + 5;

			if(Input.GetKeyDown(KeyCode.Keypad4))
				sprintForce = sprintForce - 5;

			if(sprintForce < 5)
				sprintForce = 5;

			if(sprintForce > 30)
				sprintForce = 30;


			SprintForceSlider1.GetComponent<Slider>().value = sprintForce;
			//SprintForceSlider2.GetComponent<Slider>().value = sprintForce;


			if(groundSpeed > sprintForce)
				groundSpeed = sprintForce;

			Vector3 myVelocity = new Vector3(1, 0, 0);

			if(myController.velocity.z != 0 || myController.velocity.x != 0)
				groundSpeed *= 1.03F;
			else 
				groundSpeed = 3;

			moveDirection *= groundSpeed;


			AM.audioSource.Stop();

			if(Input.GetButton("Jump")) 
			{
				moveDirection *= TempJumpLength;
				moveDirection.y = TempJumpHeight + (moveDirection.magnitude / 1.5F);

				// *****************possible fix
				Vector3 tempvec = new Vector3();
				tempvec = Vector3.ClampMagnitude(tempvec, 10f);
				// ****************************

				AM.JumpSound();
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

		//print(moveDirection);


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





