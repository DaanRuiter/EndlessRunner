using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour{

	public static ArrayList enemies = new ArrayList();

	void Update(){
		foreach(GameObject enemy in enemies){
			if(enemy.transform.position.y < 0){
				Destroy(enemy.gameObject, 1f);
			}
		}
	}

}

