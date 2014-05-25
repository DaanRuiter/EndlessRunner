using UnityEngine;
using System.Collections;

public class CloseMenu : MonoBehaviour {
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.K))
		{
			DC.paused = false;
			Destroy(this.gameObject);
		}
	}
}
