using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public string type;

	private Color hover;

	void Start(){
		hover = new Color(255,190,120);
	}

	void OnMouseOver(){
		if(Input.GetMouseButtonUp(0)){
			if(type.Equals("start")){
				Application.LoadLevel(1);
			}
		}
	}

	void OnMouseEnter(){
		this.renderer.material.color = hover;
	}

	void OnMouseExit(){
		this.renderer.material.color = Color.white;
	}
}
