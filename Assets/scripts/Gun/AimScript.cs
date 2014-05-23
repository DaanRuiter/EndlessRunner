using UnityEngine;
using System.Collections;

public class AimScript : MonoBehaviour {
	void Start()
	{
		LineRenderer line = this.GetComponent<LineRenderer>();
		line.SetVertexCount(2);
		line.SetWidth(0.2F, 0.2F);
		line.SetColors (Color.red,Color.red);
		line.material = new Material (Shader.Find("Particles/Additive"));
	}
	void Update()
	{
		if(DC.paused != true)
		{
			Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
			Vector3 dir = Input.mousePosition - pos;
			float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			bool laserSight = this.GetComponent<GunSort>().laserSight;
			if(laserSight)
			{
				LineRenderer line = this.GetComponent<LineRenderer>();
				line.SetPosition(0,(this.transform.position));
				Vector3 position = dir;
				position.z = -0.1f;
				line.SetPosition(1,(position));
			}
		}
	}
}
