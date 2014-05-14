using UnityEngine;
using System.Collections;

public class Healthbar : MonoBehaviour {
	public const float MAX_WIDTH = 2.6f;
	public const float MAX_HEIGHT = 0.45f;

	void Start(){
		Vector3 newSize;
		newSize.x = MAX_WIDTH;
		newSize.y = MAX_HEIGHT;
		newSize.z = 1;
		this.transform.localScale = newSize;
	}

	public void UpdateBar(float dmg, float mh){
		float pH = mh / 100;
		float pD = dmg / pH;
		float pW = this.transform.localScale.x / 100;
		float pTH = 100 - pD;
		float nW = pW * pTH;

		Vector3 newSize;
		newSize.x = nW;
		newSize.y = this.transform.localScale.y;
		newSize.z = this.transform.localScale.z;
		this.transform.localScale = newSize;
		if(this.transform.lossyScale.x < (MAX_WIDTH / 3) * 2 ){
			this.renderer.material.color = Color.yellow;
		}
		if(this.transform.lossyScale.x < (MAX_WIDTH / 3) * 1 ){
			this.renderer.material.color = Color.red;
		}
	}
}
//120 / 100
	//35 / 1,2
		//2,6 / 100
		//2,6 / 100
		//0,026 * 70

/*
 * 120 / 100 = 1,2 //1 percent health = 1,2 units
 * 35 / 1,2 = 29 //29 dmg is er gedaan.
 * 2,6 / 100 = 0.026 //1 percent van de bar is 0.026 units
 * 100 - 29 = 70 //70 percent total health
 * 0.026 * 70 = 1,82 //nieuwe width
 * */

