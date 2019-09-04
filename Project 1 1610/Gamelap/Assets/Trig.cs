using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trig : MonoBehaviour
{

	public float floatvaule = 6f;

	public int intvaule = 35;

	public string stringvaule = "Max";

	public int firepower;

	public UnityEvent Event;

	public void OnTriggerEnter(Collider other)
	{
		Event.Invoke();
	}
	// work in progress for experimenting just wanteed to see if i can be able to get the code to work byself and it can so yay
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
