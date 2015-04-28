using UnityEngine;
using System.Collections;

public class TurnWithRift3 : MonoBehaviour 
{

	public GameObject body;



	// Use this for initialization
	void Start () 
	{
	
	}
	

	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKey(KeyCode.E)) 
		{
			body.transform.Rotate(0, 30 * Time.deltaTime, 0);
		}

		if (Input.GetKey(KeyCode.Q))
		{
			body.transform.Rotate(0, -30 * Time.deltaTime, 0);
		}
	
	

	}
}
