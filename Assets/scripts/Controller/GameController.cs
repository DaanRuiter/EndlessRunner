using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour{

	public static ArrayList enemies = new ArrayList();

	private void Start(){
		GameObject.FindGameObjectWithTag ("BlackScreen").GetComponent<FadeScreen> ().StartFade ();
	}

	public void ResetStage()
	{
		GameObject.FindGameObjectWithTag ("PlayerController").GetComponent<PlayerController>().ResetPos ();
		GameObject.FindGameObjectWithTag ("Gun").GetComponent<GunSort>().ResetGun();
		GameObject.FindGameObjectWithTag ("Shop").GetComponent<ShopController> ().Reset ();
		GameObject.FindGameObjectWithTag ("BlackScreen").GetComponent<FadeScreen> ().StartFade ();
		GameObject[] enemys = GameObject.FindGameObjectsWithTag ("Enemy");
		GameObject[] bullets = GameObject.FindGameObjectsWithTag ("Bullet");
		GameObject[] healthbars = GameObject.FindGameObjectsWithTag ("HealthBar");
		GameObject[] enemyHealths = GameObject.FindGameObjectsWithTag("EnemyHPText");
		foreach (Object bullet in bullets) {
			Destroy (bullet);
		}
		foreach(Object enemy in enemys) {
			Destroy (enemy);
		}
		foreach(Object healthbar in healthbars) {
			Destroy (healthbar);
		}
		foreach(Object text in enemyHealths){
			Destroy(text);
		}
	}
}

