using UnityEngine;
using System.Collections;

public class UnpauzeGame : MonoBehaviour {

	//Menno

	private GameObject shop;
	private GameObject upgradeMenu;
	// Use this for initialization
	void Start () {
		StartCoroutine(PauseCoroutine());
	}
	IEnumerator PauseCoroutine() 
	{
		while (true)
		{
			if (Input.GetKeyDown(KeyCode.Escape) && DC.paused)
			{
				DC.paused = false;
				shop = GameObject.FindGameObjectWithTag ("ShopInterface");
				if(shop != null)
				{
					Destroy(shop);
				}
				upgradeMenu = GameObject.FindGameObjectWithTag("UpgradeMenu");
				if(upgradeMenu != null){
					Destroy (upgradeMenu);
				}
			}    
			yield return null;    
		}
	}
}
