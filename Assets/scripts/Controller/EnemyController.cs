using UnityEngine;
using System.Collections;

public class EnemyController : EnemyStats {

	public GameObject bullet;
	public Transform bulletSpawnPoint;

	protected bool alive;
	protected Vector2 pos;
	protected GameObject player;

	public float movementSpeed;
	public bool canShoot;
	public float shootCooldown;
	public string type;
	//types (no caps):
	//moving

	private float shootTimer;

	protected void Start () {
		shootTimer = 10f;
		alive = true;
		pos = new Vector2(this.transform.position.x, this.transform.position.y);
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	protected virtual void Update () {
		Vector3 dir = player.transform.position - this.transform.position;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		if(canShoot){
			shootTimer -= shootCooldown;
			if(shootTimer <= 0){
				Shoot();
			}
		}
		if(DC.isOutOfBounds(this.gameObject)){
			Destroy(this.gameObject, 1f);
		}
	}

	private void Shoot(){
		GameObject newBullet = Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation) as GameObject;
		shootTimer = 10f;
	}

	public float getMovementSpeed(){
		return movementSpeed;
	}
	public void LoseHealth(float dmg){
		health -= dmg;
		if(health <= 0)
		{
			Destroy(this.gameObject);
		}
	}
}
