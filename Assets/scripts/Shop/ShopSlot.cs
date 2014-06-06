using UnityEngine;
using System.Collections;

public class ShopSlot : MonoBehaviour {

	//Menno

	private string weaponSort = "";
	private float price		  = 0;
	private int speed		  = 0;
	private int dmg			  = 0;
	private int bulletSpeed   = 0;
	private float gold		  = 0;
	private bool piercing	  = false;
	private int critChance 	  = 0;
	private bool bought		  = false;
	public GUIText statsText;

	public Texture[] buttonTextures;

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
		if(weaponSort == "Rapid")
		{
			DC.SetTexture (buttonTextures[0], this.gameObject);
		} else if(weaponSort == "Shotgun")
		{
			DC.SetTexture (buttonTextures[1], this.gameObject);
		} else {
			DC.SetTexture (buttonTextures[2], this.gameObject);
		}
	}
	void OnMouseOver()
	{
		MakeText ();
	}
	void OnMouseDown()
	{
		if(price <= gold && !bought)
		{
			GameObject.FindGameObjectWithTag ("PlayerController").GetComponent<PlayerStats> ().gold -= price;
			GameObject.FindGameObjectWithTag ("Gun").GetComponent<GunSort>().SetSlotStats(weaponSort,speed,dmg,bulletSpeed,piercing,critChance);
			bought = true;
		}
	}
	void OnMouseExit()
	{
		statsText.text = "";
	}
	private void MakeText()
	{
		if(!bought){
			statsText.text = "Stats" + "\n" + "Weapon: " + weaponSort + "\n" + "Damage: " + dmg + "\n" + "Speed: " + speed + "\n" + "CritChance: " + critChance + "\n" + "Price: " + price;
		} else if(weaponSort == "Rapid"){
			statsText.text = "Out of stock!";
			DC.setTexture(this.gameObject, buttonTextures[3]);
		} else if(weaponSort == "Shotgun"){
			statsText.text = "Out of stock!";
			DC.setTexture(this.gameObject, buttonTextures[4]);
		}else {
			statsText.text = "Out of stock!";
			DC.setTexture(this.gameObject, buttonTextures[5]);
		}
	}
}
