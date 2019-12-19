using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityDisabled : MonoBehaviour
{

	public float time;
	private void OnTriggerEnter(Collider other)
	{
		StartCoroutine(Wait());
	}

	IEnumerator Wait()
	{
		yield return new WaitForSeconds(time);
		GetComponent<Rigidbody>().useGravity = true;
	}
	
	
}
