using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoookAtTut : MonoBehaviour
{

	public Transform sphere;

	
	// Update is called once per frame
	void Update () 
	{
		transform.LookAt(sphere); //this is a unity tutorial that is used to instantly look at an object oor a transform
		
	}
}
