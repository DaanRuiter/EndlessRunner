using UnityEngine;
using System.Collections;

public class AbilityController : MonoBehaviour {
	bool cdAbility01 = false; 
	float coolDown = 0.5f;
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Alpha1) && !cdAbility01)
		{
			ShootCannon();
		}
	}
	void ShootCannon(){
		cdAbility01 = true;
		Invoke ("SetCd", coolDown);
		GameObject.FindGameObjectWithTag ("Cannon").GetComponent<Cannon> ().StartAbility ();
	}
	void SetCd(){
		cdAbility01 = false;
	}
}
