using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	public static int level;
	public float gold;
	public float health;
	public float exp;
	private float expTillLevel;

	void Start () {
		health = 100;
		gold = 0;
		exp = 0;
		level = 1;
		expTillLevel = 500;
	}
	public void LoseHealth(float _dmg)
	{
		health -= _dmg;
		if(health <= 0)
		{
			Death();
		}
	}
	void Death()
	{
		GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ().ResetStage ();
	}
	public void AddGold(float _gold)
	{
		gold += _gold;
	}

	public float GetGold(){
		return gold;
	}

	public void AddExp(float _exp)
	{
		exp += _exp;
		if (expTillLevel <= exp) 
		{
			expTillLevel += expTillLevel * 0.75f;
			level += 1;
			exp = 0;
		}
	}
}
