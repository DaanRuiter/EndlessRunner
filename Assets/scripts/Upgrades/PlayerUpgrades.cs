using UnityEngine;
using System.Collections;

public class PlayerUpgrades : MonoBehaviour {
	public GameObject playerUpgradeMenu;
	void OnMouseDown () 
	{
		Vector3 pos = new Vector3(-0.7010099f,-2.540659f,-1);
		Instantiate(playerUpgradeMenu,pos,this.transform.rotation);
		Destroy(GameObject.FindGameObjectWithTag("UpgradeMenu"));
	}
}
