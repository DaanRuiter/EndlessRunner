using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	//Daan

	public Texture menuBG;
	public Texture sceneBG;
	public Texture credits;
	public Texture optionsBG;
	public GUIStyle startbutton;
	public GUIStyle optionsButton;
	public GUIStyle creditsButton;
	public GUIStyle GUIStats;

	private string optionsState;
	private string creditsState;

	private float optionsY;
	private float creditsX;
	private float optionsFinalY;
	private float creditsFinalX;
	private float optionsStartY;
	private float creditsStartX;

	private void Start(){
		creditsX = Screen.width;
		creditsFinalX = Screen.width - 650;

		optionsY = Screen.height;
		optionsFinalY = Screen.height - 550;

		optionsStartY = optionsY;
		creditsStartX = creditsX;

		creditsState = "Out";
		optionsState = "Out";
	}

	private void OnGUI(){
		GUI.DrawTexture(new Rect(0,0, Screen.width, Screen.height), sceneBG);
		GUI.DrawTexture(new Rect(0, Screen.height / 4, 300, 450), menuBG);
		GUI.DrawTexture(new Rect(creditsX, Screen.height - 800, 550, 800), credits);
		GUI.DrawTexture(new Rect(400, optionsY, 550, 500), optionsBG);
		GUI.Button(new Rect(Screen.width / 6, 100, 400, 200), "BIOHAZARD", GUIStats);

		if(GUI.Button(new Rect(20, Screen.height / 4 + 60, 200, 60), "", startbutton)){
			Application.LoadLevel(1);
		}
		if(GUI.Button(new Rect(20, Screen.height / 4 + 160, 200, 60), "", optionsButton)){
			creditsState = "GoOut";
			optionsState = "GoUp";
		}
		if(GUI.Button(new Rect(20, Screen.height / 4 + 260, 200, 60), "", creditsButton)){
			creditsState = "GoUp";
			optionsState = "GoOut";
		}
	}

	private void Update(){
		if(optionsState == "GoUp"){
			optionsY -= 10f;
			if(optionsY < optionsFinalY){
				optionsState = "InPos";
			}
		}
		if(creditsState == "GoUp"){
			creditsX -= 10f;
			if(creditsX < creditsFinalX){
				creditsState = "InPos";
			}
		}
		if(optionsState == "GoOut"){
			optionsY += 10f;
			if(optionsY >= optionsStartY){
				optionsState = "InStartPos";
			}
		}
		if(creditsState == "GoOut"){
			creditsX += 10f;
			if(creditsX >= creditsStartX){
				creditsState = "InStartPos";
			}
		}
	}
}
