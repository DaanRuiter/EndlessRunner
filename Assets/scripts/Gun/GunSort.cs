using UnityEngine;
using System.Collections;

public class GunSort : MonoBehaviour {
	public string weaponSort = "";
	public int speed		  = 0;
	public int dmg			  = 0;
	public int bulletSpeed    = 0;
	public bool piercing	  = false;

	void Start () 
	{
		weaponSort 		= "Default";
		speed      		= 30;
		dmg        		= 35;
		bulletSpeed 	= 20;
		piercing 		= false;
	}
	public void SetGunStats(string _weaponSort, int _speed, int _dmg, int _bulletSpeed, bool _piercing)
	{
		weaponSort 		= _weaponSort;
		speed      		= _speed;
		dmg        		= _dmg;
		bulletSpeed 	= _bulletSpeed;
		piercing		= _piercing;
		//SetTexture ();
	}
}
