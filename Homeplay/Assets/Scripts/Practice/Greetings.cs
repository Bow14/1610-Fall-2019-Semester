using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Greetings : MonoBehaviour
{
	private UnityEvent damn;

	private void OnTriggerStay(Collider other)
	{
		if (Input.GetKeyDown(KeyCode.G))
		{
			print("Damn son where did yooo find this");
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
