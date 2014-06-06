using UnityEngine;
using System.Collections;

public class PropSpawner : MonoBehaviour {
	private bool propSpawnable;
	private float spawnTimer;
	private Vector2 spawnPoint;
	private Vector3 propRot;

	private void Start(){
		propSpawnable = true;
		spawnTimer = 15f;
		propRot = new Vector3(0,0,0);
	}
	
	private void Update () {
		if(!DC.paused){
			spawnTimer -= 0.1f;
			if(propSpawnable && spawnTimer <= 0){
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
		spawnTimer = 30f;
		spawnPoint.x = getRandomX();
		spawnPoint.y = getRandomY();
		GameObject prop = Instantiate(DC.props[DC.GetRandomRange(DC.props.Length)], spawnPoint, Quaternion.identity) as GameObject;
		GameController.props.Add(prop);
		propRot.z = DC.GetRandomRange(360);
		prop.transform.Rotate(propRot);
		propSpawnable = true;
	}
}
