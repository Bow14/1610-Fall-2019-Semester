using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class RedoMovement : MonoBehaviour
{

	private Vector3 location;
	private CharacterController character;
	public float tempo = 10f;
	public float doubleJ = 3f;
	public float jump;
	public float force = 3f;
	public float jumpTempo = 2f;

	// Use this for initialization
	void Start ()
	{
		character = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		location.x = tempo * Input.GetAxis("Horizontal");
		location.y -= force;

		if (character.isGrounded)
		{
			location.y = 0;
			jump = 0;
		}

		if (Input.GetButtonDown("Jump") && jump < doubleJ)
		{
			jump++;
			location.y = jumpTempo;
		}

		character.Move(location * Time.deltaTime);
	}
}
