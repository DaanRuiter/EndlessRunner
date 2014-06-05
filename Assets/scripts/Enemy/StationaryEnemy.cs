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
<<<<<<< HEAD
				if(this.transform.position.y > goToPos && justSpawned){
					pos = transform.position;
					pos.y -= speed * Time.deltaTime;
					transform.position = pos;
				} else {
					Invoke("Move", 3f);
				}
				if(!justSpawned)
				{
=======
				if(this.transform.position.y > goToPos){
>>>>>>> e00675acea4e3e574c3bedb451b73244e9469a02
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
