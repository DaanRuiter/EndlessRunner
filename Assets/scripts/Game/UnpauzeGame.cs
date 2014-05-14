using UnityEngine;
using System.Collections;

public class UnpauzeGame : MonoBehaviour {
	private GameObject shop;
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
			}    
			yield return null;    
		}
	}
}
