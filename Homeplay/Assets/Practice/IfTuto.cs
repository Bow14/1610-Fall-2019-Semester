using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfTuto : MonoBehaviour {
	
	//Update is called once per frame
	//unity tutorial to understand if statements to use in experimental code
	
private float coffeeTemperature = 85.0f;
	private float hotlimitTemperature = 70.0f;
	private float coldLimitTemperature = 40.0f;
	
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
		coffeeTemperature -= Time.deltaTime * 5f;


	}

private void TemperatureTest()
	{
		if (coffeeTemperature > hotlimitTemperature)
		{
			print("Coffee is too hot.");
		}

		
		else if(coffeeTemperature < coldLimitTemperature)
		{
			print("Coffee is too cold!");
		}
		else
		{
			print("Coffee is just right!");
		}
	}
	}

 