using UnityEngine;
using System.Collections;

public class MovingEnemy : EnemyController {

	//Daan

	override protected void Update () {
		base.Update ();
		if(DC.paused == false)
		{
			if(alive){
				pos = transform.position;
				pos.y -= speed * Time.deltaTime;
				transform.position = pos;
			}
		}
	}
}
