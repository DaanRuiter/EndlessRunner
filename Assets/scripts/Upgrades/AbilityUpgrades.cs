using UnityEngine;
using System.Collections;

public class AbilityUpgrades : MonoBehaviour {
	public GameObject abilityUpgradeMenu;
	void Update () 
	{
		if(Input.GetMouseButtonDown(1)){
			Instantiate(abilityUpgradeMenu,this.transform.position,this.transform.rotation);
		}
	}
}
