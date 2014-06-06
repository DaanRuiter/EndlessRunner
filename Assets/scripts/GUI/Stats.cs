using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {

	//Daan & Menno

	private GameObject player;
	private bool cdAbility01;
	private bool cdAbility02;
	private bool[] unlocked;

	void Start(){
		player = GameObject.FindGameObjectWithTag("PlayerController");
	}

	//debugging only, later word dit alleen geupdate als er gold word ontvangen, level up etc.;
	void Update(){
		cdAbility01 = GameObject.FindGameObjectWithTag ("AbilityController").GetComponent<AbilityController> ().cdAbility01;
		cdAbility02 = GameObject.FindGameObjectWithTag ("AbilityController").GetComponent<AbilityController> ().cdAbility02;
		unlocked = GameObject.FindGameObjectWithTag ("AbilityController").GetComponent<AbilityController> ().unlocked;
		guiText.text = "GOLD : " + player.GetComponent<PlayerStats>().GetGold() + "\n";
		guiText.text += "LEVEL : " + player.GetComponent<PlayerStats>().GetLevel() + "\n";
		guiText.text += "XP : " + player.GetComponent<PlayerStats>().GetXP() + "\n";
		guiText.text += "XP NEEDED: " + (int) player.GetComponent<PlayerStats>().GetXPTillLevel() + "\n";
		guiText.text += "STAT POINTS: " + PlayerStats.statPoints + "\n";
		if(unlocked[0] == true)
		{
			guiText.text += "ABILITY ONE NOT USABLE: " + cdAbility01 + "\n";
		}
		if(unlocked[1] == true) 
		{
			guiText.text += "ABILITY TWO NOT USABLE: " + cdAbility02 + "\n";
		}
	}
}
