using UnityEngine;
using System.Collections;

public class ShopSlot : MonoBehaviour {
	private string weaponSort = "";
	private float price		  = 0;
	private int speed		  = 0;
	private int dmg			  = 0;
	private int bulletSpeed   = 0;
	private float gold		  = 0;
	private bool piercing	  = false;
	public GUIText statsText;

	void Start()
	{
		gold = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerStats> ().gold;
	}

	public void SetGunStats(string _weaponSort, float _price, int _speed, int _dmg, int _bulletSpeed, bool _piercing)
	{
		weaponSort 		= _weaponSort;
		price      		= _price;
		speed      		= _speed;
		dmg        		= _dmg;
		bulletSpeed 	= _bulletSpeed;
		piercing 		= _piercing;
		SetTexture ();
	}
	private void SetTexture()
	{
		//blablalbla
	}
	void OnMouseOver()
	{
		MakeText ();
	}
	void OnMouseDown()
	{
		if(price <= gold)
		{
			GameObject.FindGameObjectWithTag ("PlayerController").GetComponent<PlayerStats> ().gold -= price;
			GameObject.FindGameObjectWithTag ("Gun").GetComponent<GunSort>().SetGunStats(weaponSort,speed,dmg,bulletSpeed,piercing);
		}
	}
	void OnMouseExit()
	{
		statsText.text = "";
	}
	private void MakeText()
	{
		statsText.text = "Stats" + "\n" + "Weapon: " + weaponSort + "\n" + "Damage: " + dmg + "\n" + "Speed: " + speed + "\n" + "Price: " + price;
	}
}
