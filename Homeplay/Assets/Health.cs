using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

	public float health=5;

	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<PowerupHolder>())
		{
			health+= other.GetComponent<PowerupHolder>().Powerup.HealthAmount;
			print(health);
		}
	}
}
