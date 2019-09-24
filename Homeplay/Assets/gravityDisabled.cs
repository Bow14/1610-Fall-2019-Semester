using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityDisabled : MonoBehaviour {
	private void OnTriggerEnter(Collider other)
	{
		if (other == true);
		{
			GetComponent<Rigidbody>().useGravity = true;
		}
		
	}
}
