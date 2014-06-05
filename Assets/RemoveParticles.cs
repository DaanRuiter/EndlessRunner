using UnityEngine;
using System.Collections;

public class RemoveParticles : MonoBehaviour {
	private ParticleSystem particles;
	public GameObject light;
	private bool lightChangeAble;
	public Color lightcolor;
	void Start (){
		particles = this.GetComponent<ParticleSystem>();
		FadeLight ();
	}
	// Update is called once per frame
	void Update () {
		if(particles.isStopped) 
		{
			Destroy(this.gameObject);
		}
	}
	void FadeLight(){
		if(light != null)
		{
			if(light.light.color.g >= 2.5){
				lightChangeAble = true;
			} 
			if(!lightChangeAble) {
				lightcolor.g += 0.5f;
				lightcolor.r += 0.5f;
			} else if(lightChangeAble) {
				lightcolor.g -= 0.5f;
				lightcolor.r -= 0.5f;
				lightcolor.b -= 0.5f;
			}
			light.light.color = lightcolor;
			Invoke ("FadeLight", 0.1f);
		}
	}
}
