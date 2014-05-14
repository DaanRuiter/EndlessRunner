using UnityEngine;
using System.Collections;

public class RoadScroll : MonoBehaviour {
	private const float ROADHEIGHT = 20;
	private GameObject[] roads;

	public float scrollSpeed;

	void Start () {
		roads = GameObject.FindGameObjectsWithTag("Road");
		foreach(GameObject road in roads)
		{
			DC.setRandomTexture(road, DC.getTextureList(DC.roadTextures));
		}
	}
	
	void Update () {
		if(DC.paused != true)
		{
			foreach(GameObject road in roads){
				Vector2 pos = road.transform.position;
				pos.y -= scrollSpeed;
				road.transform.position = pos;
				if(road.transform.position.y < Camera.main.camera.transform.position.y - ROADHEIGHT){
					pos.y = road.transform.position.y + ROADHEIGHT * roads.Length;
					road.transform.position = pos;
					DC.setRandomTexture(road, DC.getTextureList(DC.roadTextures));
				}
			}
		}
	}
}
