using UnityEngine;
using System.Collections;

public class HealthUpgradeBut : MonoBehaviour {
	void Update () {
		if(Input.GetMouseButtonDown(1) && PlayerStats.statPoints >= 1)
		{
			PlayerStats.statPoints -= 1;
			GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerStats>().health += 10;
		}
	}
}
