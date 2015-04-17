using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LockOn : MonoBehaviour 
{

	public KeyCode scan = KeyCode.E;
	GameObject scannerMonitor1;
	GameObject scannerMonitor2;
	Text scannedObject;

	Image goalGUI1_1;
	Image goalGUI1_2;
	Image goalGUI1_3;

	Image goalGUI2_1;
	Image goalGUI2_2;
	Image goalGUI2_3;

	public int lockOnRange = 60;

	public LayerMask layerMask;

	[HideInInspector]
	public Vector3 fwd;


	// Use this for initialization
	void Start () 
	{
		scannerMonitor1 = GameObject.Find("Scanner Monitor1");
		scannerMonitor2 = GameObject.Find("Scanner Monitor2");

		goalGUI1_1 = GameObject.Find("GoalGUI1_1").GetComponent<Image>();
		goalGUI1_2 = GameObject.Find("GoalGUI1_2").GetComponent<Image>();
		goalGUI1_3 = GameObject.Find("GoalGUI1_3").GetComponent<Image>();

		goalGUI2_1 = GameObject.Find("GoalGUI2_1").GetComponent<Image>();
		goalGUI2_2 = GameObject.Find("GoalGUI2_2").GetComponent<Image>();
		goalGUI2_3 = GameObject.Find("GoalGUI2_3").GetComponent<Image>();

		goalGUI1_1.enabled = false;
		goalGUI1_2.enabled = false;
		goalGUI1_3.enabled = false;

		goalGUI2_1.enabled = false;
		goalGUI2_2.enabled = false;
		goalGUI2_3.enabled = false;

		//scannedObject = scannerMonitor1.GetComponent<Text>();
	}


	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown(scan)) 
		{
			fwd = transform.TransformDirection(Vector3.forward);
			RaycastHit hit;
			Physics.Raycast(transform.position, fwd, out hit, lockOnRange, layerMask); 
			if (hit.collider != null) 
			{
				scannerMonitor1.GetComponent<Text>().text = hit.collider.gameObject.name;
				//scannedObject.text = hit.collider.gameObject.name;
				scannerMonitor2.GetComponent<Text>().text = hit.collider.gameObject.name;

				print(hit.collider.gameObject.name);

				if (hit.collider.name == "Goal1") 
				{
					goalGUI1_1.enabled = true;
					goalGUI2_1.enabled = true;
				}

				if (hit.collider.name == "Goal2") 
				{
					goalGUI1_2.enabled = true;
					goalGUI2_2.enabled = true;
				}

				if (hit.collider.name == "Goal3") 
				{
					goalGUI1_3.enabled = true;
					goalGUI2_3.enabled = true;
				}


				if (hit.collider.name == "Goal1") 
				{
					goalGUI1_1.enabled = true;
					goalGUI2_1.enabled = true;
				}
				
				if (hit.collider.name == "Goal2") 
				{
					goalGUI1_2.enabled = true;
					goalGUI2_2.enabled = true;
				}
				
				if (hit.collider.name == "Goal3") 
				{
					goalGUI1_3.enabled = true;
					goalGUI2_3.enabled = true;
				}

				bool goalGUI1 = false;
				bool goalGUI2 = false;
				bool goalGUI3 = false;

				if(goalGUI1_1.enabled == true && goalGUI2_1.enabled == true)
					goalGUI1 = true;

				if(goalGUI1_2.enabled == true && goalGUI2_2.enabled == true)
					goalGUI2 = true;

				if(goalGUI1_3.enabled == true && goalGUI2_3.enabled == true)
					goalGUI3 = true;

				if (goalGUI1 == true && goalGUI2 == true && goalGUI3 == true) 
					Application.LoadLevel("Main");
			
			}
		}
	}	
}




