﻿using UnityEngine;
using System.Collections;

public class RoadBehaviour : MonoBehaviour {
	
	public void SetTexture(Texture text){
		Debug.Log ("setText");
		this.renderer.material.SetTexture("_MainText", text);
	}
}
