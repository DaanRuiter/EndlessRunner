using UnityEngine;
using System.Collections;

public class StationaryEnemy : EnemyController {
	private float goToPos;
	private bool justSpawned = true;
	public void SetGoToPos(float pos){
		this.goToPos = pos;
	}

	override protected void Update () {
		base.Update ();
		if(DC.paused == false)
		{
			if(alive){
				if(this.transform.position.y > goToPos && justSpawned){
					pos = transform.position;
					pos.y -= speed * Time.deltaTime;
					transform.position = pos;
				} else {
					Invoke("Move", 3f);
				}
				if(!justSpawned)
				{
					pos = transform.position;
					pos.y -= speed * Time.deltaTime;
					transform.position = pos;
				}
			}
		}
	}
	private void Move()
	{
		justSpawned = false;
	}
}
