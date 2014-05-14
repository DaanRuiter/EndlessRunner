using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float movementSpeed;
	void Update () 
	{
		if(DC.paused != true)
		{
			CharacterController controller = GetComponent<CharacterController>();
			float x = Input.GetAxis ("Horizontal");
			float y = Input.GetAxis ("Vertical");
			Vector2 moveDirection = new Vector2 (x, y);
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= movementSpeed;
			controller.Move(moveDirection * Time.deltaTime);
		}
	}
}
