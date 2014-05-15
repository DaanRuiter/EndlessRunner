using UnityEngine;
using System.Collections;

public class DC : MonoBehaviour {

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
	public static bool isOutOfBounds(GameObject obj){
		return obj.transform.position.y < Camera.main.camera.transform.position.y - Camera.main.camera.orthographicSize;
	}
}
