using UnityEngine;
using System.Collections;

public class UpgradeMenuController : MonoBehaviour {

	//Menno

	public GameObject upgradeMenu;
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.K) && !DC.paused)
		{
			DC.paused = true;
			Vector3 spawnPos = new Vector3(0,0,-5);
			Instantiate(upgradeMenu,spawnPos,this.transform.rotation);
		}
	}
}
