using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateFixedUpTut : MonoBehaviour {

	
	//this is a unity tutorial for the difference about update and  fixed update and the difference between them
	//update
	//Used for regular updates such as:
	// Moving non-phyiscis objects
	// simple timers
	// receiving input
	
	//Fixed update
	//Called Every physics step
	//Fixedupdate intervals are consistent
	// used for regular updates such as:
	//Adjusting physics (rigidbody) objects

	// Update is called once per frame
	void Update () 
	{
		Debug.Log("Updating the timeframe" + Time.deltaTime);	
	}

	private void FixedUpdate()
	{
		Debug.Log("FixedUpdateTimeframe" + Time.deltaTime);
	}
}
