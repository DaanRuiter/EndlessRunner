using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	public static int level;

	public GameObject prefab_healthBar;
	public GameObject levelAnim;

	public float gold;
	public float health;
	public float exp;
	public static int statPoints;

	private float expTillLevel;
	private GameObject healthBar;	
	private Vector3 HPPos;
	void Start () {
		health = 100;
		gold = 0;
		exp = 0;
		level = 1;
		expTillLevel = 500;
		HPPos.x = Camera.main.transform.position.x;
		HPPos.y = Camera.main.transform.position.y - Camera.main.orthographicSize + 1;
		HPPos.z = -1.1f;

		healthBar = GameObject.Instantiate(prefab_healthBar, HPPos, Quaternion.identity) as GameObject;
		healthBar.GetComponent<Healthbar>().Init(10f, 0.95f, false, HPPos.x, HPPos.y);
		healthBar.GetComponent<Healthbar>().InitHealthText(this.health);
		healthBar.tag = "PlayerHealthBar";
		healthBar.GetComponent<Healthbar>().SetTextTag("PlayerHealthText");
	}
	public void Reset () {
		health = 100;
		gold = 0;
		exp = 0;
		level = 1;
		expTillLevel = 500;
	}
	public void LoseHealth(float _dmg)
	{
		health -= _dmg;
		healthBar.GetComponent<Healthbar>().UpdateBar(this.health, _dmg, false);

		if(health <= 0)
		{
			Death();
		}
	}

	void Death()
	{
		GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ().ResetStage ();
		health = 100;
	}

	public void AddGold(float _gold)
	{
		gold += _gold;
	}

	public float GetGold(){
		return gold;
	}

	public float GetLevel(){
		return level;
	}

	public float GetXP(){
		return exp;
	}

	public float GetXPTillLevel(){
		return expTillLevel;
	}

	public void AddExp(float _exp)
	{
		exp += _exp;
		if (expTillLevel <= exp) 
		{
			expTillLevel += expTillLevel * 0.25f;
			level += 1;
			exp = 0;
			statPoints += 1;
			Quaternion rot = new Quaternion();
			GameObject levelup = Instantiate(levelAnim,this.transform.position,rot) as GameObject;
			levelup.transform.parent = this.transform;
		}
	}
}
