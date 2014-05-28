using UnityEngine;
using System.Collections;

public class theotime : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(DC.theotime){
			Texture[] theos = GameObject.FindGameObjectWithTag("DataCenter").GetComponent<DC>().theos;
			this.renderer.material.SetTexture("_MainTex", DC.getRandomTexture(theos));
		}
	}
}
