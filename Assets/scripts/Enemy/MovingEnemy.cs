﻿using UnityEngine;
using System.Collections;

public class MovingEnemy : EnemyController {
	override protected void Update () {
		base.Update ();
		if(DC.paused == false)
		{
			if(alive){
				pos = transform.position;
				pos.y -= movementSpeed * Time.deltaTime;
				transform.position = pos;
			}
		}
	}
}
