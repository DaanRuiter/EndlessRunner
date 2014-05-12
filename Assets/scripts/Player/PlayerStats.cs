using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	public float gold;
	public int health;

	void Start () {
		health = 3;
		gold = 0;
	}
}
