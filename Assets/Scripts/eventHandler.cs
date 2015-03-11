using UnityEngine;
using System.Collections;

public class eventHandler : MonoBehaviour 
{

	public delegate void powerupHandler(bool isPowered);
	
	public static event powerupHandler powerUpHandle;

	
	
	void OnGUI()
	{
		if (GUI.Button(new Rect(5, 5, 150, 40), "HI!")) 
		{
			if (powerUpHandle != null) 
			{
				powerUpHandle(true);
			}

		}

		if (GUI.Button(new Rect(5, 50, 150, 40), "HI!")) 
		{
			if (powerUpHandle != null) 
			{
				powerUpHandle(false);
			}
			
		}

	}


	// Use this for initialization
	void Start () 
	{
		
	}

	
	// Update is called once per frame
	void Update () 
	{
		
	}



}
