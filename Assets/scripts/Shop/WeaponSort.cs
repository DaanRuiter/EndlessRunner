using UnityEngine;
using System.Collections;

public class WeaponSort : MonoBehaviour {

	//Menno

	private string weaponSort;
	private float price;
	private int speed;
	private int dmg;
	public GUIText statsText;
	// Use this for initialization
	public void SetGunStats(string _weaponSort, float _price, int _speed, int _dmg)
	{
		weaponSort = _weaponSort;
		price      = _price;
		speed      = _speed;
		dmg        = _dmg;
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
	void OnMouseExit()
	{
		statsText.text = "";
	}
	private void MakeText()
	{
		statsText.text = "Stats" + "\n" + "Weapon: " + weaponSort + "\n" + "Damage: " + dmg + "\n" + "Speed: " + speed + "\n" + "Price: " + price;
	}
}
