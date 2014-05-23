using UnityEngine;
using System.Collections;

public class Healthbar : MonoBehaviour {
	public TextMesh healthPrefab;

	private float maxWidth = 2.6f;
	private float maxHeight = 0.45f;

	private float maxHealth;
	private TextMesh healthText;
	private TextMesh dmgText;
	private Vector3 HPPos;
	private Vector3 dmgPos;
	private bool follow;
	private Vector3 newSize;

	public void Init(float _width, float _height, bool _follow, float _x, float _y){
		Vector3 newSize;
		maxWidth = _width;
		maxHeight = _height;

		newSize.x = maxWidth;
		newSize.y = maxHeight;
		newSize.z = 1;

		follow = _follow;

		this.transform.localScale = newSize;
		if(follow){
			HPPos.x = this.transform.position.x - 1.2f;
			HPPos.y = this.transform.position.y + 0.3f;
			HPPos.z = this.transform.position.z;
		}else{
			SetCustomPos(_x, _y);
		}
		healthText = Instantiate(healthPrefab, HPPos, transform.rotation) as TextMesh;
	}

	private void SetCustomPos(float _x, float _y){
		HPPos.x = _x;
		HPPos.y = _y;
	}

	public void InitHealthText(float _health){
		healthText.text = "" + _health;
		maxHealth = _health;
	}

	private void Update(){
		if(follow){
			HPPos.x = this.transform.position.x - 1.2f;
			HPPos.y = this.transform.position.y + 0.3f;
			HPPos.z = this.transform.position.z;
			healthText.transform.position = HPPos;
		}

		dmgPos.x = this.transform.position.x + 1.2f;
		dmgPos.y = this.transform.position.y + 0.7f;

		if(dmgText != null){
			dmgPos.y += 0.1f;
			dmgText.transform.position = dmgPos;
		}
		dmgPos.z = this.transform.position.z;
	}

	public void UpdateBar(float _nh, float _dmg, bool _crit){

		float OnePMHP = maxHealth / 100; //een percent van Max Health
		float NPNHP = _nh / OnePMHP; //nieuwe percentage van nieuwe Health
		float OnePHPB = this.transform.localScale.x / 100; //een percent van HP-Bar
		float nW = NPNHP * OnePHPB; //Nieuwe width van de healthbar;

		newSize.x = nW;
		newSize.y = this.transform.localScale.y;
		newSize.z = this.transform.localScale.z;

		this.gameObject.transform.localScale = newSize;

		dmgText = Instantiate(healthPrefab, dmgPos, transform.rotation) as TextMesh;
		InitDmgText(_dmg, _crit);

		if(this.transform.lossyScale.x < (maxWidth / 3) * 2 ){
			this.renderer.material.color = Color.yellow;
		}
		if(this.transform.lossyScale.x < (maxHeight / 3) * 1 ){
			this.renderer.material.color = Color.red;
		}

		if(this.transform.lossyScale.x < 0){
			newSize.x = 0;
			this.transform.localScale = newSize;
		}

		healthText.text = "" + _nh;
	}

	public TextMesh GetText(){
		return healthText;
	}

	public void addText(string txt){
		healthText.text += txt;
	}

	public void SetTextTag(string _tag){
		healthText.tag = _tag;
	}

	public void ResetBar(){
		newSize.x = maxWidth;
		newSize.y = maxHeight;
		this.transform.localScale = newSize;
		healthText.text = "" + maxHealth;
		this.transform.renderer.material.color = Color.green;
	}

	private void InitDmgText(float _dmg, bool _crit){
		dmgText.color = Color.yellow;
		dmgText.text = "-" + _dmg;
		if(_crit){
			dmgText.color = Color.red;
			dmgText.characterSize += 0.05f;
			dmgText.text += "!";
			dmgText.text = "<i>" + dmgText.text + "</i>";
		}
		dmgText.text = "<b>" + dmgText.text + "</b>";
		Destroy(dmgText.gameObject, 0.5f);
	}

}
