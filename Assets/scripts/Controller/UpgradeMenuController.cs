using UnityEngine;
using System.Collections;

public class UpgradeMenuController : MonoBehaviour {
	public GameObject upgradeMenu;
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.K))
		{
			DC.paused = true;
			Instantiate(upgradeMenu,this.transform.position,this.transform.rotation);
		}
	}
}
