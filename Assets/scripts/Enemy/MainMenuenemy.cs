using UnityEngine;
using System.Collections;

public class MainMenuenemy : MonoBehaviour {

	public float movementSpeed;

	private Vector3 pos;
	private string type;

	void Start(){
		pos = new Vector3(this.transform.position.x, this.transform.position.y, -0.2f);
		type = "idle";
	}

	void Update () {
		pos.y -= movementSpeed;
		this.transform.position = pos;
		if(DC.isOutOfBounds(this.gameObject)){
			Destroy(this.gameObject, 1f);
		}
	}

	public string GetEnemType(){
		return type;
	}
}
