using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	private const float LEVEL_X_MIN = -10;
	private const float LEVEL_X_MAX = 10;
	private const float LEVEL_Y_MIN = 20;
	private const float LEVEL_Y_MAX = 25;

	public GameObject movingEnemy;

	private bool enemySpawnable;
	private float spawnTimer;
	private Vector2 spawnPoint;

	private void Start(){
		enemySpawnable = true;
		spawnTimer = 10f;
	}

	private void Update () {
		if(!DC.paused){
			spawnTimer -= 0.1f;
			if(enemySpawnable && spawnTimer <= 0){
				SpawnEnemy("moving");
			}
		}
	}

	private float getRandomX(){
		float r =  Random.Range(LEVEL_X_MIN, LEVEL_X_MAX);
		return r;
	}

	private float getRandomY(){
		float r =  Random.Range(LEVEL_Y_MIN, LEVEL_Y_MAX);
		return r;
	}

	private void SpawnEnemy(string type){
		if(type.Equals("moving")){
			spawnTimer = 10;
			spawnPoint.x = getRandomX();
			spawnPoint.y = getRandomY();
			GameObject enem = Instantiate(movingEnemy, spawnPoint, Quaternion.identity) as GameObject;
			GameController.enemies.Add(enem);
			enemySpawnable = true;
		}
	}
}
