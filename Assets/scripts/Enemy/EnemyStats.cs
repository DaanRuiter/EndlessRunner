using UnityEngine;
using System.Collections;

public class EnemyStats : MonoBehaviour {
	protected const float MAX_HEALTH = 100f;
	protected float health = 100f;
	protected float speed = Random.Range(1.35f, 1.8f);
}
