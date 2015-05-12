using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LockOn : MonoBehaviour 
{

	public KeyCode scan = KeyCode.F;
	GameObject scannerMonitor1;
	GameObject scannerMonitor2;
	Text scannedObject;

	Image goalGUI1_Land;
	Image goalGUI2_Land;
	Image goalGUI3_Land;

	Image goalGUI1_Mountain;
	Image goalGUI2_Mountain;
	Image goalGUI3_Mountain;

	Image goalGUI1_Cave;
	Image goalGUI2_Cave;
	Image goalGUI3_Cave;

	Image goalGUI1_Mordor;
	Image goalGUI2_Mordor;
	Image goalGUI3_Mordor;

	public int lockOnRange = 60;

	public LayerMask layerMask;

	[HideInInspector]
	public Vector3 fwd;


	// Use this for initialization
	void Start () 
	{
		scannerMonitor1 = GameObject.Find("Scanner Monitor1");

		goalGUI1_Land = GameObject.Find("GoalGUI1_1").GetComponent<Image>();
		goalGUI2_Land = GameObject.Find("GoalGUI1_2").GetComponent<Image>();
		goalGUI3_Land = GameObject.Find("GoalGUI1_3").GetComponent<Image>();

		goalGUI1_Mountain = GameObject.Find("GoalGUI2_1").GetComponent<Image>();
		goalGUI2_Mountain = GameObject.Find("GoalGUI2_2").GetComponent<Image>();
		goalGUI3_Mountain = GameObject.Find("GoalGUI2_3").GetComponent<Image>();

		goalGUI1_Cave = GameObject.Find("GoalGUI3_1").GetComponent<Image>();
		goalGUI2_Cave = GameObject.Find("GoalGUI3_2").GetComponent<Image>();
		goalGUI3_Cave = GameObject.Find("GoalGUI3_3").GetComponent<Image>();

		goalGUI1_Mordor = GameObject.Find("GoalGUI4_1").GetComponent<Image>();
		goalGUI2_Mordor = GameObject.Find("GoalGUI4_2").GetComponent<Image>();
		goalGUI3_Mordor = GameObject.Find("GoalGUI4_3").GetComponent<Image>();


		goalGUI1_Land.enabled = false;
		goalGUI2_Land.enabled = false;
		goalGUI3_Land.enabled = false;

		goalGUI1_Mountain.enabled = false;
		goalGUI2_Mountain.enabled = false;
		goalGUI3_Mountain.enabled = false;

		goalGUI1_Cave.enabled = false;
		goalGUI2_Cave.enabled = false;
		goalGUI3_Cave.enabled = false;

		goalGUI1_Mordor.enabled = false;
		goalGUI2_Mordor.enabled = false;
		goalGUI3_Mordor.enabled = false;

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
				//scannerMonitor1.GetComponent<Text>().text = hit.collider.gameObject.name;
				//scannedObject.text = hit.collider.gameObject.name;
				//scannerMonitor2.GetComponent<Text>().text = hit.collider.gameObject.name;

				print(hit.collider.gameObject.name);

				if (hit.collider.name == "Goal1_Land") 
				{
					goalGUI1_Land.enabled = true;
				}

				if (hit.collider.name == "Goal2_Land") 
				{
					goalGUI2_Land.enabled = true;
				}

				if (hit.collider.name == "Goal3_Land") 
				{
					goalGUI3_Land.enabled = true;
				}
				//**************************************

				if (hit.collider.name == "Goal1_Mountain") 
				{
					goalGUI1_Mountain.enabled = true;
				}
				
				if (hit.collider.name == "Goal2_Mountain") 
				{
					goalGUI2_Mountain.enabled = true;
				}
				
				if (hit.collider.name == "Goal3_Mountain") 
				{
					goalGUI3_Mountain.enabled = true;
				}
				//***************************************

				if (hit.collider.name == "Goal1_Cave") 
				{
					goalGUI1_Cave.enabled = true;
				}
				
				if (hit.collider.name == "Goal2_Cave") 
				{
					goalGUI2_Cave.enabled = true;
				}
				
				if (hit.collider.name == "Goal3_Cave") 
				{
					goalGUI3_Cave.enabled = true;
				}
				//***************************************
				
				if (hit.collider.name == "Goal1_Mordor") 
				{
					goalGUI1_Mordor.enabled = true;
				}
				
				if (hit.collider.name == "Goal2_Mordor") 
				{
					goalGUI2_Mordor.enabled = true;
				}
				
				if (hit.collider.name == "Goal3_Mordor") 
				{
					goalGUI3_Mordor.enabled = true;
				}

				bool goalGUI1 = false;
				bool goalGUI2 = false;
				bool goalGUI3 = false;

				bool goalGUI4 = false;
				bool goalGUI5 = false;
				bool goalGUI6 = false;

				bool goalGUI7 = false;
				bool goalGUI8 = false;
				bool goalGUI9 = false;

				bool goalGUI10 = false;
				bool goalGUI11 = false;
				bool goalGUI12 = false;

				if(goalGUI1_Land.enabled == true)
					goalGUI1 = true;

				if(goalGUI2_Land.enabled == true)
					goalGUI2 = true;

				if(goalGUI3_Land.enabled == true)
					goalGUI3 = true;


				if(goalGUI1_Mountain.enabled == true)
					goalGUI4 = true;
				
				if(goalGUI2_Mountain.enabled == true)
					goalGUI5 = true;
				
				if(goalGUI3_Mountain.enabled == true)
					goalGUI6 = true;
			

				if(goalGUI1_Cave.enabled == true)
					goalGUI7 = true;
				
				if(goalGUI2_Cave.enabled == true)
					goalGUI8 = true;
				
				if(goalGUI3_Cave.enabled == true)
					goalGUI9 = true;


				if(goalGUI1_Mordor.enabled == true)
					goalGUI10 = true;
				
				if(goalGUI2_Mordor.enabled == true)
					goalGUI11 = true;
				
				if(goalGUI3_Mordor.enabled == true)
					goalGUI12 = true;

				if (goalGUI1 == true && goalGUI2 == true && goalGUI3 == true && 
				    goalGUI4 == true && goalGUI5 == true && goalGUI6 == true && 
				    goalGUI7 == true && goalGUI8 == true && goalGUI9 == true &&
				    goalGUI10 == true && goalGUI11 == true && goalGUI12 == true) 
					Application.LoadLevel("Main");
			
			}
		}
	}	
}




