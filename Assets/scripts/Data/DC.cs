using UnityEngine;
using System.Collections;

public class DC : MonoBehaviour {
	//custom datacenter

	public static float LEVEL_X_MIN = -10;
	public static float LEVEL_X_MAX = 10;
	public static float LEVEL_Y_MIN = 20;
	public static float LEVEL_Y_MAX = 22;

	public Texture[] _bulletTextures;
	public Texture[] _roadTextures;

	public static bool paused;
	public static Texture[] roadTextures;


	void Awake(){
		roadTextures = _roadTextures;
	}

	public static void setRandomTexture(GameObject obj, Texture[] text){
		obj.renderer.material.SetTexture("_MainTex", text[GetRandomRange(text.Length)]);
	}

	public static Texture[] getTextureList(Texture[] text){
		return text;
	}

	public static Texture getTexture(Texture[] list, int index){
		return list[index];
	}

	public static void SetTexture(Texture _text, GameObject _obj){
		_obj.renderer.material.SetTexture("_MainTex", _text);
	}

	public static int GetRandomRange(int _range){
		int r = (int) Random.Range(0, _range);
		if(r < 0){r = 0;}
		return r;
	}

	public static int GetRandomRange(float x, float y){
		int r = (int) Random.Range(x, y);
		if(r < 0){r = 0;}
		return r;
	}

	public static bool isOutOfBounds(GameObject obj){
		return obj.transform.position.y < Camera.main.camera.transform.position.y - Camera.main.camera.orthographicSize;
	}

	public static bool isOutOfBoundsUp(GameObject obj){
		return obj.transform.position.y > Camera.main.camera.transform.position.y + Camera.main.camera.orthographicSize;
	}
}
