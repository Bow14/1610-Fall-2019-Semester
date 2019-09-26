using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rubber : MonoBehaviour
{
	public Vector3 bouncy;

	private Rigidbody rb;
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody>();

	}

	private void OnCollisionEnter(Collision other)
	{
		Debug.Log("Bounce");
		rb.AddForce(bouncy);
	}
}
