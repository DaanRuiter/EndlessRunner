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
	public Texture[] theos;
	public static bool theotime;

	public static bool paused;
	public static Texture[] roadTextures;

	private int cheat = 0;
	private ArrayList textures = new ArrayList();

	void Awake(){
		roadTextures = _roadTextures;
		textures.Add (roadTextures);
	}

	public static void setRandomTexture(GameObject obj, Texture[] text){
		obj.renderer.material.SetTexture("_MainTex", text[GetRandomRange(text.Length)]);
	}

	public static Texture getRandomTexture(Texture[] text){
		return text[GetRandomRange(text.Length)];
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
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.T)) {
			cheat = 1;
		}if (Input.GetKeyDown(KeyCode.H) && cheat == 1) {
			cheat += 1;
		}if (Input.GetKeyDown(KeyCode.E) && cheat == 2) {
			cheat+= 1;
		}if (Input.GetKeyDown(KeyCode.O) && cheat == 3) {
			ActivateCheat();
		}
	}
	void ActivateCheat(){
		theotime = true;
		for(int i = 0; i < textures.Count; i++){
			foreach(Texture[] text in textures){
				for(int j = 0; j < text.Length; j++){
					text[j] = getRandomTexture(theos);
				}
			}
		}
		GameObject[] allObjects = GameObject.FindObjectsOfType<GameObject>();
		foreach (GameObject g in allObjects) {
			if(g.renderer) {
				g.renderer.material.SetTexture("_MainTex", getRandomTexture(theos));
			}
		}
		GUIText[] texts = GameObject.FindObjectsOfType<GUIText> ();
		foreach(GUIText d in texts)
		{
			d.text = "THEO THEO THEO THEO THEO THEO THEO THEO!!";
		}
	}
}
