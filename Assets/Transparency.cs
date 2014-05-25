using UnityEngine;
using System.Collections;

public class Transparency : MonoBehaviour {

	public GameObject g;

	void Start () {
		renderer.material.color = new Color(1,1,1,0.5f);
	}

}
