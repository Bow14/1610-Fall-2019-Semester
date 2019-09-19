using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class Damove : MonoBehaviour

{
	private CharacterController controller;
	public float moveSpeed = 10f;
	public float gravity = 3f;
	public float jumpSpeed = 30f;
	private Vector3 position;

	public void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	void Update ()
	{
		position.x = moveSpeed*Input.GetAxis("Horizontal");
		position.y -= gravity;

		if (Input.GetButtonDown("Jump"))
		{
			position.y = jumpSpeed;
		}
		controller.Move(position * Time.deltaTime);

	}
}
