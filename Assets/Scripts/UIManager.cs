using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour 
{
	public GUISkin myGuiSkin;
	public Texture2D background, logo;

	private Rect windowRect = new Rect((Screen.width / 2) - 250, (Screen.height / 2) - 250, 400, 500);

	private string menuState;

	public GUIStyle mainStyle;
	public GUIStyle buttonStyle;
	
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
			GUI.DrawTexture(new Rect(Screen.width / 2 -300, 30, 600, 200), logo);

		GUI.skin = myGuiSkin;

		if (menuState == main) 
		{
			windowRect = GUI.Window(0, windowRect, MenuFunc, "Main Menu", mainStyle);
		}

		if (menuState == options) 
		{
			windowRect = GUI.Window(1, windowRect, OptionsFunc, "Options", mainStyle);
		}

		if (menuState == credits)
		{
			GUI.Box(new Rect(0, 0, Screen.width, Screen.height), textToDisplay, mainStyle);
		}
	}


	void MenuFunc(int id)
	{
		if (GUILayout.Button("Play Game", buttonStyle))
		{
			StartCoroutine("OculusFunc");
		}
		if (GUILayout.Button("Options", buttonStyle)) 
		{
			menuState = options;
		}
		if (GUILayout.Button("Credits", buttonStyle))
		{
			menuState = credits;
		}
		if (GUILayout.Button("Quit Game", buttonStyle))
		{
			Application.Quit();
		}
	}


	void OptionsFunc(int id)
	{
		GUILayout.Box("Volume", buttonStyle);
		volume = GUILayout.HorizontalSlider(volume, 0.0f, 1.0f);
		AudioListener.volume = volume;
		if (GUILayout.Button("Back", buttonStyle)) 
			menuState = main;
	}


	IEnumerator OculusFunc()
	{
		GUILayout.Box("Please put on the Oculus Rift virtual reality headset and look directly forward so you are facing the Oculus Rift Camera.", mainStyle);
		yield return new WaitForSeconds(10);
		Application.LoadLevel("scene1");
	}

	// Update is called once per frame
	void Update () 
	{
		if (menuState == credits && Input.GetKey(KeyCode.Escape)) 
			menuState = main;
	
	}
}






