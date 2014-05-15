using UnityEngine;
using System.Collections;

public class Healthbar : MonoBehaviour {
	public const float MAX_WIDTH = 2.6f;
	public const float MAX_HEIGHT = 0.45f;

	public TextMesh healthPrefab;

	private TextMesh healthText;	

	public void Init(){
		Vector3 newSize;
		newSize.x = MAX_WIDTH;
		newSize.y = MAX_HEIGHT;
		newSize.z = 1;
		this.transform.localScale = newSize;
		Vector3 HPPos;
		HPPos.x = this.transform.position.x - 1.2f;
		HPPos.y = this.transform.position.y + 0.3f;
		HPPos.z = this.transform.position.z;
		healthText = Instantiate(healthPrefab, HPPos, transform.rotation) as TextMesh;
		healthText.transform.parent = transform;
	}

	public void InitHealthText(float _health){
		healthText.text = "" + _health;
	}

	public void UpdateBar(float _dmg, float _mh){
		float pH = _mh / 100;
		float pD = _dmg / pH;
		float pW = this.transform.localScale.x / 100;
		float pTH = 100 - pD;
		float nW = pW * pTH;

		Vector3 newSize;
		newSize.x = nW;
		newSize.y = this.transform.localScale.y;
		newSize.z = this.transform.localScale.z;
		this.gameObject.transform.localScale = newSize;
		if(this.transform.lossyScale.x < (MAX_WIDTH / 3) * 2 ){
			this.renderer.material.color = Color.yellow;
		}
		if(this.transform.lossyScale.x < (MAX_WIDTH / 3) * 1 ){
			this.renderer.material.color = Color.red;
		}

		if(this.transform.lossyScale.x < 0){
			newSize.x = 0;
			this.transform.localScale = newSize;
		}

		healthText.text = "" + _mh;
	}
}
