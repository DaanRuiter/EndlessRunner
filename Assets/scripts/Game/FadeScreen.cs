using UnityEngine;
using System.Collections;

public class FadeScreen : MonoBehaviour {
	Color color = Color.black;
	public void StartFade()
	{
		color.a = 1;
		this.renderer.material.color = color;
		Fade ();
	}
	void Fade()
	{
		color.a = color.a - 0.01f;
		this.renderer.material.color = color;
		if (color.a > 0) 
		{
			Invoke("Fade", 0.01f);
		}
	}
}
