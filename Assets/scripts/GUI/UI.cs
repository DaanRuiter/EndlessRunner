using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

	public Texture UITexture;
	Vector3 pos;

	void OnGUI(){
		GUI.DrawTexture(new Rect(0,
		                         0,
		                         Screen.width,
		                         Screen.height),
		                		 UITexture);
	}
}