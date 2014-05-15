using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	public float gold;
	public int lives;

	void Start () {
		lives = 3;
		gold = 0;
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
	public void AddGold(float _gold){
		gold += _gold;
	}

	public float GetGold(){
		return gold;
	}
}
