using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {
	private bool aiming = false;
	private bool haveBullet = false;
	public void StartAbility()
	{
		aiming = true;
		haveBullet = true;
	}
	void Update()
	{
		if(aiming)
		{
			if(DC.paused != true)
			{
				Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
				Vector3 dir = Input.mousePosition - pos;
				float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
				transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
				if (Input.GetMouseButton (0) && haveBullet) 
				{
					ShootCannon();
				}
			}
		}
	}
	private void ShootCannon()
	{
		aiming = false;
		haveBullet = false;
		//Instantiate (cannonBullet, aimPoint.transform.position, aimPoint.rotation);
	}
}
