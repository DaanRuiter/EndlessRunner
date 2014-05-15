using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {

	private GameObject player;

	void Start(){
		player = GameObject.FindGameObjectWithTag("PlayerController");
	}

	//debugging only, later word dit alleen geupdate als er gold word ontvangen;
	void Update(){
		guiText.text = "" + player.GetComponent<PlayerStats>().GetGold();
	}
}
