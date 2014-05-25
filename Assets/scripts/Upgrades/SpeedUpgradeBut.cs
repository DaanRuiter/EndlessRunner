using UnityEngine;
using System.Collections;

public class SpeedUpgradeBut : MonoBehaviour {
	void OnMouseDown () {
		if(PlayerStats.statPoints >= 1)
		{
			PlayerStats.statPoints -= 1;
			GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerController>().movementSpeed += 0.25f;
		}
	}
}
