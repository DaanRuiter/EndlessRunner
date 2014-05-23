using UnityEngine;
using System.Collections;

public class AttackRange : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D col){
		if(col.transform.tag.Equals("Player")){
			this.transform.parent.GetComponent<EnemyController>().setRangeState(true);
			Debug.Log ("true");
		}
	}

	private void OnTriggerExit2D(Collider2D col){
		if(col.transform.tag.Equals("Player")){
			this.transform.parent.GetComponent<EnemyController>().setRangeState(false);
			Debug.Log ("true");
		}
	}
}
