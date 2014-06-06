using UnityEngine;
using System.Collections;

public class GranadeLauncherBut : MonoBehaviour {
	void OnMouseDown(){
		if(PlayerStats.statPoints >= 1)
		{
			PlayerStats.statPoints -= 1;
			GameObject.FindGameObjectWithTag("Gun").GetComponent<GunSort>().granadeLauncher = true;
		}
	}
}
