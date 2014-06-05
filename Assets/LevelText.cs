using UnityEngine;
using System.Collections;

public class LevelText : MonoBehaviour {
	private Color textColor = Color.cyan;
	private Vector3 transPos;
	private float counter;

	void Start () {
		transPos = new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z);
	}
	void Update () 
	{
		TextMesh text = this.GetComponent<TextMesh> ();
		counter += 0.001f;
		transPos.x = this.transform.position.x;
		transPos.z = this.transform.position.z;
		transPos.y = this.transform.position.y + counter;
		textColor.a -= 0.01f;
		text.color = textColor;
		this.transform.position = transPos;
	}
}
