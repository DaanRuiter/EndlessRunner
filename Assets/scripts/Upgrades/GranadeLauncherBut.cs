using UnityEngine;
using System.Collections;

public class GranadeLauncherBut : MonoBehaviour {
	void Update(){
		if(Input.GetMouseButtonDown(1) && PlayerStats.statPoints >= 3 && PlayerStats.level >= 5)
		{
			PlayerStats.statPoints -= 3;
			GameObject.FindGameObjectWithTag("Gun").GetComponent<GunSort>().laserSight = true;
		}
	}
}
