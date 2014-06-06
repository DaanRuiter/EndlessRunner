using UnityEngine;
using System.Collections;

public class AbilityUpgrades : MonoBehaviour {
	public GameObject abilityUpgradeMenu;
	void OnMouseDown () 
	{
		Vector3 pos = new Vector3(0,0,-5);
		Instantiate(abilityUpgradeMenu,pos,this.transform.rotation);
		Destroy(GameObject.FindGameObjectWithTag("UpgradeMenu"));
	}
}
