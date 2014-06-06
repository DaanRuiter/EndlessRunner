using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour{

	public static ArrayList enemies = new ArrayList();
	public static ArrayList props = new ArrayList();

	private void Start(){
		GameObject.FindGameObjectWithTag ("BlackScreen").GetComponent<FadeScreen> ().StartFade ();
		for(int i = enemies.Count-1;i > 0; i--)
		{
			enemies.RemoveAt(i);
		}
		for(int i = props.Count-1;i > 0; i--)
		{
			props.RemoveAt(i);
		}
	}

	public void ResetStage()
	{
		for(int i = enemies.Count-1;i > 0; i--)
		{
			enemies.RemoveAt(i);
		}
		for(int i = props.Count-1;i > 0; i--)
		{
			props.RemoveAt(i);
		}
		GameObject.FindGameObjectWithTag ("BlackScreen").GetComponent<FadeScreen> ().StartFade ();
		GameObject.FindGameObjectWithTag ("PlayerController").GetComponent<PlayerController>().ResetPos ();
		GameObject.FindGameObjectWithTag ("Gun").GetComponent<GunSort>().ResetGun();
		GameObject.FindGameObjectWithTag ("Shop").GetComponent<ShopController> ().Reset ();
		GameObject.FindGameObjectWithTag("PlayerHealthBar").GetComponent<Healthbar>().ResetBar();
		GameObject.FindGameObjectWithTag ("PlayerController").GetComponent<PlayerStats> ().Reset ();
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
		foreach(Object prop in props){
			Destroy(prop);
		}
	}
}

