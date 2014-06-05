using UnityEngine;
using System.Collections;

public class AbilityController : MonoBehaviour {
	private bool cdAbility01 = false; 
	private bool cdAbility02 = false;
	private float coolDown = 5f;
	private bool[] unlocked = new bool[2];
	void Start () {
		unlocked [0] = false;
		unlocked [1] = false;
		}
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Alpha1) && !cdAbility01 && unlocked[0])
		{
			ShootCannon();
		}
		if(Input.GetKeyDown (KeyCode.Alpha2) && !cdAbility02 && unlocked[1])
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
	public void UnlockAbility(int number){
		unlocked[number] = true;
	}
}
