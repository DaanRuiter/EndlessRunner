using UnityEngine;
using System.Collections;

public class Ability02But : MonoBehaviour {
	void OnMouseDown(){
		if(PlayerStats.statPoints != 0)
		{
			PlayerStats.statPoints -= 1;
			GameObject.FindGameObjectWithTag("AbilityController").GetComponent<AbilityController>().UnlockAbility(2);
		}
	}
}
