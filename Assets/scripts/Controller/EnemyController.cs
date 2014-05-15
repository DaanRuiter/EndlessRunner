using UnityEngine;
using System.Collections;

public class EnemyController : EnemyStats {

	public GameObject bullet;
	public Transform bulletSpawnPoint;
	public GameObject HPBarPrefab;

	protected bool alive;
	protected bool inRange;
	protected Vector2 pos;
	protected GameObject player;
	protected GameObject healthBar;
	protected Vector3 barPos;

	public float movementSpeed;
	public bool canShoot;
	public float shootCooldown;
	public string type;
	//types (no caps):
	//moving

	private float shootTimer;

	protected void Start () {
		shootTimer = 0f;
		alive = true;
		pos = new Vector2(this.transform.position.x, this.transform.position.y);
		player = GameObject.FindGameObjectWithTag("Player");

		barPos.x = this.transform.position.x;
		barPos.y = this.transform.position.y + 1f;
		barPos.z = - 0.2f;

		healthBar = GameObject.Instantiate(HPBarPrefab, barPos, Quaternion.identity) as GameObject;
		healthBar.GetComponent<Healthbar>().Init();
		healthBar.GetComponent<Healthbar>().InitHealthText(this.health);
	}
	
	protected virtual void Update () {
		if(DC.paused != true){
			Debug.Log (health);
			Vector3 dir = player.transform.position - this.transform.position;
			float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

			barPos.x = this.transform.position.x;
			barPos.y = this.transform.position.y + 1f;

			healthBar.transform.position = barPos;

			if(canShoot && inRange){
				shootTimer -= shootCooldown;
				if(shootTimer <= 0){
					Shoot();
				}
			}

			if(DC.isOutOfBounds(this.gameObject)){
				DestroyMe(1);
			}
		}
	}
	private void Shoot(){
		GameObject newBullet = Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation) as GameObject;
		shootTimer = Random.Range(10, 14);
	}

	public float getMovementSpeed(){
		return movementSpeed;
	}

	public void LoseHealth(float _dmg){
		health -= _dmg;

		if(health <= 0)		{
			DestroyMe();
			GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerStats>().AddGold(gold);
		}

		healthBar.GetComponent<Healthbar>().UpdateBar(this.health, _dmg);
	}

	public void setRangeState(bool state){
		inRange = state;
	}

	public void DestroyMe(){
		Destroy(this.gameObject);
		Destroy(healthBar.gameObject);
		Destroy(healthBar.GetComponent<Healthbar>().GetText());
	}

	public void DestroyMe(float _time){
		Destroy(this.gameObject, _time);
		Destroy(healthBar.gameObject, _time);
		Destroy(healthBar.GetComponent<Healthbar>().GetText(), _time);
	}
}
