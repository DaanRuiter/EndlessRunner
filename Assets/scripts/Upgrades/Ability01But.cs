﻿using UnityEngine;
using System.Collections;

public class Ability01But : MonoBehaviour {
	void Update()
	{
		if(Input.GetMouseButtonDown(1) && PlayerStats.statPoints != 0)
		{
			PlayerStats.statPoints -= 1;
			GameObject.FindGameObjectWithTag("AbilityController").GetComponent<AbilityController>().UnlockAbility(1);
		}
	}
}
