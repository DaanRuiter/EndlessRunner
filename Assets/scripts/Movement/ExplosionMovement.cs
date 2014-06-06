using UnityEngine;
using System.Collections;

public class ExplosionMovement : MonoBehaviour {

	//Menno

	private GameObject camTransform;
	public float shake = 0f;
	public float shakeAmount = 0.7f;
	public float decreaseFactor = 1.0f;
	public AudioClip sound;
	private Vector3 originalPos;
	// Use this for initialization
	void Start () {
		camTransform = GameObject.FindGameObjectWithTag ("MainCamera");
		originalPos = camTransform.transform.localPosition;
		audio.PlayOneShot(sound);
	}
	void Update () {
		if (shake > 0)
		{
			camTransform.transform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
			shake -= Time.deltaTime * decreaseFactor;
		}
		else
		{
			shake = 0f;
			camTransform.transform.localPosition = originalPos;
		}
	}
}
