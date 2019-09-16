using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sytutorial : MonoBehaviour {

	
	// Use this for initialization
	//unity tutorial code will probably use for experimental code and slightly fixed import code problem
	
	void Start () 
	{
		Debug.Log(transform.position.x);
		if (transform.position.y <= 5f)
		{
			Debug.Log("Im about to fall!");
		}
		
	}
	
	// Update is called once per frame
}
