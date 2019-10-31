using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class WeaponMaster : MonoBehaviour {

	public WeaponData weaponDataObj;

	public void WeaponSwitch(WeaponData data)
	{
		weaponDataObj = data;
	}
	
	public void onActivate()
	{
		weaponDataObj.Activate();
	}

	public void Update()
	{
		
	}
}
