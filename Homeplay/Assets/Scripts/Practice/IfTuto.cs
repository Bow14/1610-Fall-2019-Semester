using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfTuto : MonoBehaviour {
	
	//Update is called once per frame
	//unity tutorial to understand if statements to use in experimental code
	
private float normalTemperature = 85.0f;
	private float HotdayTemperature = 70.0f;
	private float coldTemperature = 40.0f;
	
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
		normalTemperature -= Time.deltaTime * 5f;


	}

private void TemperatureTest()
	{
		if (normalTemperature> HotdayTemperature)
		{
			print("Day is too hot.");
		}

		
		else if(normalTemperature < coldTemperature)
		{
			print("Day is too cold");
		}
		else
		{
			print("the day is perfect");
		}
	}
	}

 