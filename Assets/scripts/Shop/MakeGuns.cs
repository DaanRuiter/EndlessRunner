using UnityEngine;
using System.Collections;

public class MakeGuns : MonoBehaviour {
	public ArrayList GetGun()
	{
		int random 			  = Random.Range (1, 4);
		float price 		  = 0f;
		string randomSort	  = "";
		int speedStat		  = Random.Range(60,90);
		int dmgStat			  = Random.Range(40,60);
		int bSpeed 			  = 10;
		bool piercing		  = false;
		ArrayList weaponStats = new ArrayList ();

		switch(random)
		{
		case 1:
			randomSort = "Rapid";
			speedStat += 5;
			dmgStat -= 20;
			bSpeed += 10;
			price = (dmgStat*50*0.5f) + (speedStat*50*0.3f) + 250;
			piercing = false;
			break;
		case 2:
			randomSort = "Shotgun";
			speedStat -= 45;
			dmgStat += 4;
			bSpeed += 5;
			price = (dmgStat*50*0.5f) + (speedStat*50*0.3f) + 250;
			piercing = false;
			break;
		case 3:
			randomSort = "Sniper";
			speedStat -= 55;
			dmgStat += 45;
			bSpeed += 20;
			price = (dmgStat*50*0.5f) + (speedStat*100*0.3f) + 250;
			piercing = true;
			break;
		default:
			break;
		}
		weaponStats.Add (randomSort);
		weaponStats.Add (dmgStat);
		weaponStats.Add (speedStat);
		weaponStats.Add (price);
		weaponStats.Add (bSpeed);
		weaponStats.Add (piercing);

		return weaponStats;
	}
}
