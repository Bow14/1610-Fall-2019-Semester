using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireweapon : MonoBehaviour
{
	public ApplyForce ammo;
	
	// Update is called once per frame
	public void Fire () {
		{
			Instantiate(ammo, transform.position, Quaternion.identity);
		}
		
	}
}
