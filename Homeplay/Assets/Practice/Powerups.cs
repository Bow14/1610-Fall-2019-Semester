using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class Powerups : ScriptableObject
{

	public float HealthAmount = 1f;
	public float minValue = 0;
	public float maxValue = 1f;

	public void UpdateVaule(float amount)
	{
		HealthAmount += amount;
	}


	public void UpdateValueRange(float amount)
	{
		if (HealthAmount <= maxValue )
		{
			UpdateVaule(amount);
		}

		if (HealthAmount >= minValue)
		{
			UpdateVaule(amount);
		}
		else
		{
			HealthAmount = minValue;
		}
		
		
	}

}
