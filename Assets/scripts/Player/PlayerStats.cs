using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	public static int level;
	public float gold;
	public int lives;
	public float exp;
	private float expTillLevel;

	void Start () {
		lives = 3;
		gold = 0;
		exp = 0;
		level = 1;
		expTillLevel = 500;
	}
	public void LoseLive()
	{
		lives -= 1;
		if(lives <= 0)
		{
			Death();
		}
	}
	void Death()
	{
		//maak animatie dood + retry!
	}
	public void AddGold(float _gold)
	{
		gold += _gold;
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
