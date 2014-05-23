using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {
	public float destroyTime;
	protected float speed;
	protected float dmg;
	protected bool piercing;
	protected int critChance;
	void Start () 
	{
		Destroy(gameObject, destroyTime);
	}

	public void setStats(float _speed, float _dmg, bool _piercing,int _critChance/*, Texture _bullet*/)
	{
		speed 	= _speed;
		dmg 	= _dmg;
		piercing = _piercing;
		critChance = _critChance;
		//this.renderer.material.SetTexture
	}
	void Update () 
	{
		if(DC.paused != true)
		{
			this.transform.Translate (new Vector2(0,1) * speed * Time.deltaTime);
		}
	}
	protected virtual void OnTriggerEnter2D(Collider2D other)
	{
		if(other.transform.tag == "Enemy")
		{
			int criticalStrike = Random.Range(0,101);

			if(criticalStrike > critChance){
				float extradmg = Random.Range(0,5);
				other.gameObject.GetComponent<EnemyController>().LoseHealth(dmg + extradmg, false);
			} else {
				float extradmg = Random.Range(10,15);

				other.gameObject.GetComponent<EnemyController>().LoseHealth(dmg + extradmg, true);
			}
			if(!piercing)
			{
				Destroy(this.gameObject);
			}
		}

		Debug.Log (other.transform.tag);
		if(other.transform.tag == "Barrier") 
		{
			Destroy(this.gameObject);
		}

	}
}
