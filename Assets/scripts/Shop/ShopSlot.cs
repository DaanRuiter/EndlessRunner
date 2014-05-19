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
	private int critChance 	  = 0;
	public GUIText statsText;

	void Start()
	{
		gold = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerStats> ().gold;
	}

	public void SetGunStats(string _weaponSort, float _price, int _speed, int _dmg, int _bulletSpeed, bool _piercing, int _critChance)
	{
		weaponSort 		= _weaponSort;
		price      		= _price;
		speed      		= _speed;
		dmg        		= _dmg;
		bulletSpeed 	= _bulletSpeed;
		piercing 		= _piercing;
		critChance 		= _critChance;
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
			GameObject.FindGameObjectWithTag ("Gun").GetComponent<GunSort>().SetSlotStats(weaponSort,speed,dmg,bulletSpeed,piercing,critChance);
		}
	}
	void OnMouseExit()
	{
		statsText.text = "";
	}
	private void MakeText()
	{
		statsText.text = "Stats" + "\n" + "Weapon: " + weaponSort + "\n" + "Damage: " + dmg + "\n" + "Speed: " + speed + "\n" + "CritChance: " + critChance + "\n" + "Price: " + price;
	}
}
