using UnityEngine;
using System.Collections;

public class HealthUpgradeBut : MonoBehaviour {
	void OnMouseDown () {
		if(PlayerStats.statPoints >= 1)
		{
			PlayerStats.statPoints -= 1;
			GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerStats>().health += 10;
		}
	}
}
