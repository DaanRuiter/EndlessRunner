using UnityEngine;
using System.Collections;

public class PlayerUpgrades : MonoBehaviour {
	public GameObject playerUpgradeMenu;
	void Update () 
	{
		if(Input.GetMouseButtonDown(1)){
			Instantiate(playerUpgradeMenu,this.transform.position,this.transform.rotation);
		}
	}
}
