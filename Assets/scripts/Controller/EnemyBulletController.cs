using UnityEngine;
using System.Collections;

public class EnemyBulletController : BulletController 
{
	void Start () 
	{
		speed = 5.5f;
		dmg = 25f;
	}
	protected override void OnTriggerEnter2D(Collider2D other) {
		if(other.transform.tag == "Player"){
			GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerStats>().LoseHealth(dmg);
			Destroy(this.gameObject);
		}
	}
}
