using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statementif : MonoBehaviour {

	// Use this for initialization
	public int a = 4;
	public int b = 5;
	public int c = 10;

	public bool lightsOn = false;
	public string password = "Friend";
	void Start () 
	{
		if (a+b != c)
		{
			print(true);
			
		}
		else
		{
			print(false);
		}

		if (password != "OU812")
		{
			print(true);
		}

		if (!lightsOn)
		{
		print(true);
			
		}
		
	}
	
	// Update is called once per frame
}
