using UnityEngine;
using System.Collections;

public class WeaponUpgradeButton : MonoBehaviour {
	public GameObject weaponUpgradeMenu;
	void Update () 
	{
		if(Input.GetMouseButtonDown(1)){
			Instantiate(weaponUpgradeMenu,this.transform.position,this.transform.rotation);
		}
	}
}
