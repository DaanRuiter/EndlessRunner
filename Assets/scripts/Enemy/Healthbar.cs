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