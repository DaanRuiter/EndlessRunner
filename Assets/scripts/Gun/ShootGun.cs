using UnityEngine;
using System.Collections;

public class ShootGun : MonoBehaviour {
	public Transform spawnPoint;
	public GameObject bullet;
	private bool shootAble = true;
	
	void Update () 
	{
		if(DC.paused != true)
		{
			if (Input.GetMouseButton (0) && shootAble) 
			{
				float shootSpeed 	=  1 - (0.01f*(float)this.GetComponent<GunSort>().speed);
				float dmg 			= this.GetComponent<GunSort>().dmg;
				float bulletSpeed 	= this.GetComponent<GunSort>().bulletSpeed;
				bool piercing	    = this.GetComponent<GunSort>().piercing;
				int critChance		= this.GetComponent<GunSort>().critChance;
				ShootBullet(/*bullet,*/ shootSpeed, dmg, bulletSpeed,piercing,critChance);
			}
		}
	}
	private void ShootBullet(/*Texture _bullet,*/ float _shootSpeed, float _dmg, float _speed,bool _piercing,int _critChance)
	{
		//audio.Play(); 
		//audio.pitch = Random.Range (1f, 10f);
		shootAble = false;
		Invoke( "ShootAble", _shootSpeed);
		string gunSort = this.GetComponent<GunSort> ().weaponSort;
		if(gunSort != "Shotgun")
		{
			var newBullet = Instantiate (bullet, spawnPoint.position, spawnPoint.rotation) as GameObject;
			newBullet.GetComponent<BulletController> ().setStats (_speed, _dmg, _piercing, _critChance/*, _bullet*/);
		} else 
		{
			float extraRot = -0.1f;
			for(int i = 0; i < 3; i++)
			{
				Quaternion spawnPointRot = spawnPoint.rotation;
				spawnPointRot.z += extraRot;
				var newBullet = Instantiate (bullet, spawnPoint.position, spawnPointRot) as GameObject;
				newBullet.GetComponent<BulletController> ().setStats (_speed, _dmg, _piercing, _critChance/*, _bullet*/);
				extraRot += 0.1f;
			}
		}
	}
	private void ShootAble()
	{
		shootAble = true;
	}
}
