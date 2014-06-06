using UnityEngine;
using System.Collections;

public class MakeFireTrail : MonoBehaviour {

	//Menno

	public GameObject fire;
	private bool coolDown;
	void Update()
	{
		if(DC.paused != true)
		{
			bool fireTrail = GameObject.FindGameObjectWithTag("Gun").GetComponent<GunSort>().fireTrail;
			if(fireTrail && !coolDown)
			{
				coolDown = true;
				Invoke("SetCooldown", 0.1f);
				Instantiate(fire,this.transform.position,this.transform.rotation);
			}
		}
	}
	void SetCooldown()
	{
		coolDown = false;
	}
}
