using UnityEngine;
using System.Collections;

public class AttackRange : MonoBehaviour {

	//Daan

	private void OnTriggerEnter2D(Collider2D col){
		if(col.transform.tag.Equals("Player")){
			this.transform.parent.GetComponent<EnemyController>().setRangeState(true);
		}
	}

	private void OnTriggerExit2D(Collider2D col){
		if(col.transform.tag.Equals("Player")){
			this.transform.parent.GetComponent<EnemyController>().setRangeState(false);
		}
	}
}
