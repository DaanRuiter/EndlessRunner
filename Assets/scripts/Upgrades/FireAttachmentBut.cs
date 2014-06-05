using UnityEngine;
using System.Collections;

public class FireAttachmentBut : MonoBehaviour {
	void OnMouseDown () 
	{
		if(PlayerStats.statPoints >= 5 && PlayerStats.level >= 5)
		{
			PlayerStats.statPoints -= 5;
			GameObject.FindGameObjectWithTag("Gun").GetComponent<GunSort>().fireTrail = true;
		}
	}
}
