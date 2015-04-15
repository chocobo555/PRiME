using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour 
{
	public GUISkin myGuiSkin;
	public Texture2D background, logo;

	private Rect windowRect = new Rect((Screen.width / 2) - 100, Screen.height / 2, 200, 200);

	private string menuState;

	private string main = "main";
	private string options = "options";
	private string credits = "credits";

	private string textToDisplay = "Credits \n";

	private float volume;

	public string[] creditsTextLines = new string[0];


	// Use this for initialization
	void Start () 
	{
		menuState = main;

		for(int i = 0; i < creditsTextLines.Length; i++) 
		{
			textToDisplay += creditsTextLines[i] + "\n";
		}
		textToDisplay += "Press Esc to go back";
	}

	private void OnGUI()
	{
		if (background != null) 
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), background);

		if (logo != null) 
			GUI.DrawTexture(new Rect(Screen.width / 2 -100, 30, 200, 200), logo);

		GUI.skin = myGuiSkin;

		if (menuState == main) 
		{
			windowRect = GUI.Window(0, windowRect, MenuFunc, "Main Menu");
		}

		if (menuState == options) 
		{
			windowRect = GUI.Window(1, windowRect, OptionsFunc, "Options");
		}

		if (menuState == credits)
		{
			GUI.Box(new Rect(0, 0, Screen.width, Screen.height), textToDisplay);
		}
	}


	void MenuFunc(int id)
	{
		if (GUILayout.Button("Play Game"))
		{
			Application.LoadLevel("level1");
		}
		if (GUILayout.Button("Options")) 
		{
			menuState = options;
		}
		if (GUILayout.Button("Credits"))
		{
			menuState = credits;
		}
		if (GUILayout.Button("Quit Game"))
		{
			Application.Quit();
		}
	}


	void OptionsFunc(int id)
	{
		GUILayout.Box("Volume");
		volume = GUILayout.HorizontalSlider(volume, 0.0f, 1.0f);
		AudioListener.volume = volume;
		if (GUILayout.Button("Back")) 
			menuState = main;
	}


	// Update is called once per frame
	void Update () 
	{
		if (menuState == credits && Input.GetKey(KeyCode.Escape)) 
			menuState = main;
	
	}
}






