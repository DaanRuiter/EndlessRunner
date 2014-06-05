using UnityEngine;
using System.Collections;

public class GunSort : MonoBehaviour {
	public string weaponSort = "";
	public int speed		  = 0;
	public int dmg			  = 0;
	public int bulletSpeed    = 0;
	public int critChance     = 0;
	private int dCritChance   = 0;
	public bool laserSight    = true;
	public bool granadeLauncher = true;
	public bool fireTrail	  = true;
	public bool piercing	  = false;

	void Start () 
	{
		ResetGun ();
	}
	public void SetSlotStats(string _weaponSort, int _speed, int _dmg, int _bulletSpeed, bool _piercing, int _critChance)
	{
		weaponSort 		= _weaponSort;
		speed      		= _speed;
		dmg        		= _dmg;
		bulletSpeed 	= _bulletSpeed;
		piercing		= _piercing;
		critChance      = _critChance;
		dCritChance 	= _critChance;
		SetTexture ();
	}
	void SetTexture () 
	{
		//blalblal
	}
	public void CritSpecial()
	{
		critChance = 100;
		Invoke ("OffCrit", 2f);
	}
	void OffCrit()
	{
		critChance = dCritChance;
	}
	public void ResetGun()
	{
		weaponSort 		= "Default";
		speed      		= 50;
		dmg        		= 35;
		bulletSpeed 	= 20;
		piercing 		= false;
		critChance 		= 10;
		fireTrail 		= false;
		granadeLauncher = false;
		laserSight 		= false;
	}
}
