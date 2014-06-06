using UnityEngine;
using System.Collections;

public class WeaponUpgradeButton : MonoBehaviour {
	public GameObject weaponUpgradeMenu;
	void OnMouseDown () 
	{
		Vector3 pos = new Vector3(0,0,-5);
		Instantiate(weaponUpgradeMenu,pos,this.transform.rotation);
		Destroy(GameObject.FindGameObjectWithTag("UpgradeMenu"));
	}
}
