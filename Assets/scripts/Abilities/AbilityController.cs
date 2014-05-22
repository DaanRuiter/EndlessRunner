using UnityEngine;
using System.Collections;

public class AbilityController : MonoBehaviour {
	bool cdAbility01 = false; 
	bool cdAbility02 = false;
	float coolDown = 5f;
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Alpha1) && !cdAbility01)
		{
			ShootCannon();
		}
		if(Input.GetKeyDown (KeyCode.Alpha2) && !cdAbility02)
		{
			GetCriticals();
		}
	}
	void ShootCannon(){
		cdAbility01 = true;
		Invoke ("SetCd01", coolDown);
		GameObject.FindGameObjectWithTag ("Cannon").GetComponent<Cannon> ().StartAbility ();
	}
	void GetCriticals()
	{
		cdAbility02 = true;
		Invoke ("SetCd02", coolDown);
		GameObject.FindGameObjectWithTag ("Gun").GetComponent<GunSort> ().CritSpecial ();
	}
	void SetCd01(){
		cdAbility01 = false;
	}
	void SetCd02(){
		cdAbility02 = false;
	}
}
