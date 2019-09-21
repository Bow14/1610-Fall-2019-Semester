using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoopTutoiral : MonoBehaviour {
	
	//This is the unity tutorial module for loops so i can gain a little more understanding to use for my games and such
	//sorry that im doing a bunch of tutorials just trying to get comfortable before heavy experimenting

	public int bearshunted = 4;
	
	// Use this for initialization
	void Start () 
	{
		while (bearshunted > 0)
		{
			 Debug.Log("Bear Has been killed");
			 bearshunted--;
		}

	}
	
	
}
