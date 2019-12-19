using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
	public string playerName;
	private int myNumber;
	
	public float speed = 5;

	public GameObject player;

	public Color playerColor = Color.red;
	// Use this for initialization
	void Start ()
	{
		configGameObject();
	}

	private GameObject configGameObject()
	{
		var newPlayer = Instantiate(player);
		newPlayer.layer = 0;
		newPlayer.active = true;
		newPlayer.tag = "Player";
		newPlayer.transform.position = Vector3.zero;
		newPlayer.name = playerName;
		newPlayer.GetComponent<Renderer>().material.color = playerColor;
		return newPlayer;
	}
	private float IncreaseSpeed(float multiplier)
	{
		return speed * multiplier;
	}

	private void OnTriggerEnter(Collider other)
	{
		speed = IncreaseSpeed(2f);
	}

	private string WelcomePlayer()
	{
		//Add Player To DataBase
		//Give Player Weapons

		return playerName + "Welcome to the Game!";
	}

	private int AddNumbers(int a, int b)
	{
		print(a + b);
		return a + b;
	}
}
