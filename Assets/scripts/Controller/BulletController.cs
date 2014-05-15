using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {
	public float destroyTime;
	protected float speed;
	protected float dmg;
	protected bool piercing;
	void Start () 
	{
		Destroy(gameObject, destroyTime);
	}
	
	void OnCollisionEnter(Collision other) 
	{
		if(other.transform.tag == "Barrier") 
		{
			Destroy(this.gameObject);
		}
	}
	public void setStats(float _speed, float _dmg, bool _piercing/*, Texture _bullet*/)
	{
		speed 	= _speed;
		dmg 	= _dmg;
		piercing = _piercing;
		//this.renderer.material.SetTexture
	}
	void Update () 
	{
		if(DC.paused != true)
		{
			this.transform.Translate (new Vector2(0,1) * speed * Time.deltaTime);
			Vector2 pos = this.transform.position;
			pos.y -= 3f * Time.deltaTime;
			this.transform.position = pos;
		}
	}
	protected virtual void OnTriggerEnter2D(Collider2D other)
	{
		if(other.transform.tag == "Enemy")
		{
			other.gameObject.GetComponent<EnemyController>().LoseHealth(dmg);
			if(!piercing)
			{
				Destroy(this.gameObject);
			}
		}
	}
}
