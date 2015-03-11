using UnityEngine;
using System.Collections;

public class eventListener : MonoBehaviour 
{


	void OnEnable()
	{
		eventHandler.powerUpHandle += OnPoweredUp;
	}


	void OnDisable()
	{
		eventHandler.powerUpHandle -= OnPoweredUp;
	}


	void OnPoweredUp(bool isPowered)
	{
		Debug.Log(isPowered);
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
