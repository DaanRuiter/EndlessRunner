using UnityEngine;
using System.Collections;

public class ChasingEnemy : EnemyController {

	//Daan

	private Transform target;	

	private bool going;
	private float dmg;
	private float coolDown;

	override protected void Start(){
		base.Start ();
		going = true;
		target = GameObject.FindGameObjectWithTag("PlayerController").transform;
		speed = 10f;
		dmg = 8f + (2 * GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerStats>().GetLevel());
	}

	override protected void Update(){
		base.Update ();
		if(!DC.paused){
			if(going){
				this.transform.position = Vector3.MoveTowards(transform.position, target.position, 1.2f * Time.deltaTime);
			}

			if(this.transform.position.y < target.position.y - 1f){
				going = false;
			}

			if(inRange){
				coolDown -= shootCooldown;
				if(coolDown <= 10){
					Stab();
				}
			}
		}
	}

	private void Stab(){
		//play anim;
		coolDown += 10f;
		GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerStats>().LoseHealth(dmg);
	}

}
