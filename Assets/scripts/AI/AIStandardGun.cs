using UnityEngine;
using System.Collections;

public class AIStandardGun : MonoBehaviour {
	
	public float shootCooldown;
	public GameObject bullet;

	private GameObject player;
	private float shootTimer;

	private void Start(){
		shootTimer = 10f;
	}

	private void Update(){
		shootTimer -= shootCooldown;
		if(shootTimer <= 0){
			Shoot();
		}
	}

	private void Shoot(){
		Debug.Log ("Shoot");
		Instantiate(bullet, transform.position, transform.rotation);
		shootTimer = 10f;
	}
	
}
