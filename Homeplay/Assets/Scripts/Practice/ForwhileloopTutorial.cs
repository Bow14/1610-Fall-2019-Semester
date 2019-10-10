using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwhileloopTutorial : MonoBehaviour {
	//this is a unity tutorial as you would expect i would experiment today but i just went through a lot of messed up shit today so i just want to finish studying loops
	// Use this for initialization
	private int numAllie = 5;
	void Start () 
	{
		for (int i = 0; i < numAllie; i++)
		{
			Debug.Log("You have a allie" + i);
			
		}
			
	}
	
	
}
