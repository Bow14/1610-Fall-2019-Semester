using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{

	private Rigidbody rb;
	public Vector3Data forceDirection;
	public float force = 5f;
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		rb.AddForce(forceDirection.value * force);

	}
	
	
}
