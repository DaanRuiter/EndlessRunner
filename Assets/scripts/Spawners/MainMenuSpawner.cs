using UnityEngine;
using System.Collections;

public class MainMenuSpawner : MonoBehaviour {

	public GameObject[] enemyTypes;

	private bool enemySpawnable;
	private float spawnTimer;
	private Vector2 spawnPoint;

	private void Start(){
		enemySpawnable = true;
		spawnTimer = 0f;
	}

	private void Update () {
		if(!DC.paused){
			spawnTimer -= 0.1f;
			if(enemySpawnable && spawnTimer <= 0){
				SpawnEnemy();
			}
		}
	}

	private float getRandomX(){
		float r =  Random.Range(DC.LEVEL_X_MIN, DC.LEVEL_X_MAX);
		return r;
	}

	private float getRandomY(){
		float r =  Random.Range(DC.LEVEL_Y_MIN, DC.LEVEL_Y_MAX);
		return r;
	}

	private void SpawnEnemy(){
		spawnTimer = 12.5f;
		spawnPoint.x = getRandomX();
		spawnPoint.y = getRandomY();
		Instantiate(enemyTypes[DC.GetRandomRange(enemyTypes.Length)], spawnPoint, Quaternion.identity);
		enemySpawnable = true;
	}
}
