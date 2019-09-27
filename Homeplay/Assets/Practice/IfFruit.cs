using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfFruit : MonoBehaviour
{

	public bool appleirsRipe, orangeIsRipe, peachIsRipe;
	// Use this for initialization
	void Start () 
	{
		if (appleirsRipe)
		{
			print("Go Pick the Apple");
			
		}
		else if (orangeIsRipe)
		{
			print("Go Pick the Orange");
		}
		else if (peachIsRipe)
		{
		print("go pick the peach");
		
		}
		else 
		{
			print("Nothing is good");	
		}
		
		
		

		}
	
	// Update is called once per frame
}
