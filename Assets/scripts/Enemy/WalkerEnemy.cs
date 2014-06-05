using UnityEngine;
using System.Collections;

public class WalkerEnemy : EnemyController {
	private int direction = 1;
	override protected void Update () {
		base.Update ();
		if(DC.paused == false)
		{
			if(alive){
				pos = transform.position;
				pos.y -= speed * Time.deltaTime;
				pos.x += direction * (speed+2) * Time.deltaTime;
				transform.position = pos;
			}
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		if(other.transform.tag == "Barrier")
		{
			direction = direction * -1;
		}
	}
}
