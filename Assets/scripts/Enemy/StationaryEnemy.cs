using UnityEngine;
using System.Collections;

public class StationaryEnemy : EnemyController {
	private float goToPos;

	public void SetGoToPos(float pos){
		this.goToPos = pos;
	}

	override protected void Update () {
		base.Update ();
		if(DC.paused == false)
		{
			if(alive){
				if(this.transform.position.y > goToPos){
					pos = transform.position;
					pos.y -= speed * Time.deltaTime;
					transform.position = pos;
				}
			}
		}
	}
}
