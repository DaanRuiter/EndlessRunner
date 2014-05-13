using UnityEngine;
using System.Collections;

public class ShopController : MonoBehaviour {
	private bool inToStage 			= false;
	private bool backInvokeAble 	= true;
	private bool startInvokeAble 	= true;
	private bool activeState		= true;
	private float movementSpeed 	= 3.1f;
	private float beginPoint;
	private float WeaponAmmount 	= 3f;
	private string[] gunSort 		= new string[3];
	private float[] gunPrice 		= new float[3];
	private int[] gunDmg 			= new int[3];
	private int[] gunSpeed 			= new int[3];
	private int[] gunBulletSpeed 	= new int[3];
	private bool[] gunPiercing		= new bool[3];

	public float endPoint;
	public GameObject shopInterface;

	void Start()
	{
		beginPoint = this.transform.position.y;
	}
	void Update () 
	{
		//als de shop in de stage mag komen.
		if (inToStage) 
		{
			if(this.transform.position.y <= endPoint)
			{
				this.transform.Translate (new Vector2 (0f, 1f) * movementSpeed * Time.deltaTime);
			} 
			else if(startInvokeAble)
			{
				activeState = true;
				startInvokeAble = false;
				float randomTime = Random.Range (3f, 5f);
				Invoke("GoOutGame", randomTime);
				getGun();
			}
		}
		//als de shop niet in de stage mag.
		else if(this.transform.position.y >= beginPoint)
		{
			activeState = false;
			this.transform.Translate (new Vector2 (0f, -1f) * movementSpeed * Time.deltaTime);
		} 
		else if(backInvokeAble)
		{
			float randomTime = Random.Range (3f, 10f);
			Invoke ("GoInGame", randomTime);
			backInvokeAble = false;
		}
	}
	private void GoInGame()
	{
		inToStage = true;
		backInvokeAble = true;
	}
	private void GoOutGame()
	{		
		inToStage = false;
		startInvokeAble = true;
	}
	void OnTriggerStay2D(Collider2D other)
	{
		if(other.transform.tag == "Player")
		{
			if(Input.GetKeyDown(KeyCode.E) && activeState)
			{
				Time.timeScale = 0;
				Vector2 spawnPos = new Vector2(0,0);
				Instantiate(shopInterface,spawnPos,this.transform.rotation);
				SetGun();
			}
		}
	}
	void getGun()
	{
		for(int i = 0; i < WeaponAmmount; i++)
		{
			ArrayList gunstat = GameObject.FindGameObjectWithTag("GameController").GetComponent<MakeGuns>().GetGun() as ArrayList;
			gunSort[i] 			= (string)gunstat[0];
			gunDmg[i]  			= (int)gunstat[1];
			gunSpeed[i] 		= (int)gunstat[2];
			gunPrice[i] 		= (float)gunstat[3];
			gunBulletSpeed[i] 	= (int)gunstat[4];
			gunPiercing[i]		= (bool)gunstat[5];
		}
	}
	void SetGun()
	{
		for(int i = 0; i < WeaponAmmount; i++)
		{
			GameObject.Find("Weapon-" + (i+1)).GetComponent<ShopSlot>().SetGunStats(gunSort[i],gunPrice[i],gunSpeed[i],gunDmg[i],gunBulletSpeed[i],gunPiercing[i]);
		}
	}
}
