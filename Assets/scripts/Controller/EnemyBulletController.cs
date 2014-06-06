using UnityEngine;
using System.Collections;

public class EnemyBulletController : BulletController 
{
	//Menno

	void Start () 
	{
		speed = 5.5f;
		dmg = 4f + (1 * GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerStats>().GetLevel());
	}
	protected override void OnTriggerEnter2D(Collider2D other) {
		if(other.transform.tag == "Player"){
			GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerStats>().LoseHealth(dmg);
			Destroy(this.gameObject);
		}
	}
}
