using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	public static int level;

	public GameObject prefab_healthBar;

	public float gold;
	public int lives;
	public float exp;

	private float expTillLevel;
	private GameObject healthBar;

	void Start () {
		lives = 3;
		gold = 0;
		exp = 0;
		level = 1;
		expTillLevel = 500;
		Vector3 HPPos;
		HPPos.x = 0;
		HPPos.y = -8;
		HPPos.z = -0.1f;

		healthBar = GameObject.Instantiate(prefab_healthBar, HPPos, Quaternion.identity) as GameObject;
		healthBar.GetComponent<Healthbar>().Init(15f, 1f, false, HPPos.x, HPPos.y);
		healthBar.GetComponent<Healthbar>().InitHealthText(this.lives);
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
