﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{

	// Use this for initialization
	// This is a unity tutorial #3
	//And using this experience for future coding experiments 

	

	void Start()
	{
		Debug.Log(transform.position.x);
		if (transform.position.y <= 8f) ;
		{
			Debug.Log("Im going to hit the ground!");
		}

	}
}	
