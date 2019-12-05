using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			transform.rotation = Quaternion.Euler(0, 100, 0);

		}

		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			transform.rotation = Quaternion.Euler(0, 0, 0);
		}
		
	}
}
