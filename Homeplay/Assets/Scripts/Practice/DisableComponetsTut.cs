using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableComponetsTut : MonoBehaviour {

	// Use this for initialization
	private Light myLight;
	//This is a unity tutorial teaching me about disabling componets which should be neat
	void Start ()
	{
		myLight = GetComponent<Light>(); //gotta get the light function from unity
	}
	
	// Update is called once per frame
	void Update ()
	{
		myLight.enabled = !myLight.enabled; //This is a toggle for the light
		//I believe the bool would also work for this
	}
}
