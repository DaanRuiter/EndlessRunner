using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float movementSpeed;
	public Transform tank;
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

			this.transform.position = tank.position;
			tank.transform.localPosition = new Vector3(0,0,0);
		}
	}
	public void ResetPos()
	{
		Vector2 oldPos = new Vector2(0,0);
		this.transform.position = oldPos;
	}
}
