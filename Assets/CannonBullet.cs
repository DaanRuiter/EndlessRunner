using UnityEngine;
using System.Collections;

public class CannonBullet : BulletController {
	private float bombRadius = 7.5f;
	private float bombDamage = 700f;
	public GameObject explosion;
	void Start()
	{
		speed = 10f;
	}
	protected override void OnTriggerEnter2D(Collider2D other) {
		if(other.transform.tag == "Enemy") 
		{
			Explode();
		}
	}
	private void Explode()
	{
		Collider2D[] colliders = Physics2D.OverlapCircleAll (transform.position, bombRadius);
		foreach(Collider2D col in colliders)
		{
			if(col.transform.tag == "Enemy") 
			{
				col.GetComponent<EnemyController>().LoseHealth(bombDamage, false);
			}
		}
		Vector3 pos = this.transform.position;
		pos.z = -0.4f;
		Instantiate (explosion, pos, this.transform.rotation);
		Destroy (this.gameObject);
	}
}
