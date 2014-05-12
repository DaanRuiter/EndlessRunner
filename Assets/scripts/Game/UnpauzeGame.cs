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
			if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 0)
			{
				Time.timeScale = 1;
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
