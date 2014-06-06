using UnityEngine;
using System.Collections;

public class PlayerUpgrades : MonoBehaviour {
	public GameObject playerUpgradeMenu;
	void OnMouseDown () 
	{
		Vector3 pos = new Vector3(0,0,-5);
		Instantiate(playerUpgradeMenu,pos,this.transform.rotation);
		Destroy(GameObject.FindGameObjectWithTag("UpgradeMenu"));
	}
}
