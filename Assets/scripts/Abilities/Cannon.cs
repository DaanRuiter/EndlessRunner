using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {
	private bool aiming = false;
	public GameObject cannonBullet;
	public Transform aimPoint;
	private bool haveBullet = false;
	private Quaternion beginRot = new Quaternion();

	void Start()
	{
		beginRot = this.transform.rotation;
	}

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
				angle -= 90;
				transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
				if (Input.GetMouseButton (1) && haveBullet) 
				{
					ShootCannon();
				}
			}
		} else if(this.gameObject.transform.rotation.z > beginRot.z)
		{
			Quaternion thisRot = this.transform.rotation;
			thisRot.z -= 0.005f;
			this.transform.rotation = thisRot;
		} else if(this.gameObject.transform.rotation.z < beginRot.z)
		{
			Quaternion thisRot = this.transform.rotation;
			thisRot.z += 0.005f;
			this.transform.rotation = thisRot;
		}
	}
	private void ShootCannon()
	{
		aiming = false;
		haveBullet = false;
		Instantiate (cannonBullet, aimPoint.position, aimPoint.rotation);
	}
}
