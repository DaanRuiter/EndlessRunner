using UnityEngine;
using System.Collections;

public class FireTrail : MonoBehaviour {

	//Menno

	private bool coolDown = false;
	void Start()
	{
		Destroy (this.gameObject, 1.5f);
	}
	void OnTriggerStay2D(Collider2D other)
	{
		if(other.transform.tag == "Enemy" && !coolDown)
		{
			coolDown = true;
			Invoke("SetCooldown", 0.5f);
			float enemyhealth = other.GetComponent<EnemyController>().health;
			float dmg = Mathf.Floor(enemyhealth*0.1f);
			other.GetComponent<EnemyController>().LoseHealth(dmg,false);
		}
	}
	void SetCooldown()
	{
		coolDown = false;
	}
}
