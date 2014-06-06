using UnityEngine;
using System.Collections;

public class GranadeController : CannonBullet {

	//Menno

	float explodeTime = 2f;
	bool moving = true;
	void Start()
	{
		bombDamage = (20*PlayerStats.level)*0.75f;
		speed = 10f;
		Invoke ("Explode", explodeTime);
		Invoke ("StopMoving", 1f);
	}
	protected override void Update()
	{
		if(DC.paused != true)
		{
			if(moving){
				this.transform.Translate (new Vector2(0,1) * speed * Time.deltaTime);
				Vector2 pos = this.transform.position;
				pos.y -= 3f * Time.deltaTime;
				this.transform.position = pos;
				bool fireTrail = GameObject.FindGameObjectWithTag("Gun").GetComponent<GunSort>().fireTrail;
				if(fireTrail)
				{
					//instantiate fireTrail
				}
			}
		}
	}
	void StopMoving(){
		moving = false;
	}
}
