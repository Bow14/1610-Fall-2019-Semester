using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStartDifference : MonoBehaviour {

	// Use this for initialization
	
	//This is a unity tutorial just seeing the difference and stuff between start and awake and see when to use oone more than the other
	void Start () 
	{
		Debug.Log("Im booting up batman!");
		
	}
	
	// Update is called once per frame
	private void Awake()
	{
		Debug.Log("Awake im awake!!");
	}
}
