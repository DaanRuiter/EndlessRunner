using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {

	//Daan

	private GameObject player;

	void Start(){
		player = GameObject.FindGameObjectWithTag("PlayerController");
	}

	//debugging only, later word dit alleen geupdate als er gold word ontvangen, level up etc.;
	void Update(){
		guiText.text = "GOLD : " + player.GetComponent<PlayerStats>().GetGold() + "\n";
		guiText.text += "LEVEL : " + player.GetComponent<PlayerStats>().GetLevel() + "\n";
		guiText.text += "XP : " + player.GetComponent<PlayerStats>().GetXP() + "\n";
		guiText.text += "XP NEEDED: " + (int) player.GetComponent<PlayerStats>().GetXPTillLevel() + "\n";
		guiText.text += "STAT POINTS: " + PlayerStats.statPoints + "\n";
	}
}
