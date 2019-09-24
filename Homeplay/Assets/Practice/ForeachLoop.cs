using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoop : MonoBehaviour {

	// Use this for initialization
	//this is a unity tutorial as you would expect i would experiment today but i just went through a lot of messed up shit today so i just want to finish studying loops
	void Start () 
	{
		string[] strings = new string[3];

		strings[0] = "First String";
		strings[1] = "Second String";
		strings[2] = "Third String";
		foreach (string item in strings)
		{
			print(item);
			
		}

	}
	
	
}
