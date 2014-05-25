using UnityEngine;
using System.Collections;

public class FireAttachmentBut : MonoBehaviour {
	void Update () 
	{
		if(Input.GetMouseButtonDown(1) && PlayerStats.statPoints >= 5 && PlayerStats.level >= 10)
		{
			PlayerStats.statPoints -= 5;
			GameObject.FindGameObjectWithTag("Gun").GetComponent<GunSort>().laserSight = true;
		}
	}
}
