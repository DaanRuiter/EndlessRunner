using UnityEngine;
using System.Collections;

public class SpeedUpgradeBut : MonoBehaviour {
	void Update () {
		if(Input.GetMouseButtonDown(1) && PlayerStats.statPoints >= 1)
		{
			PlayerStats.statPoints -= 1;
			GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerController>().movementSpeed += 0.25f;
		}
	}
}
