using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ouchi : MonoBehaviour
{
	public UnityEvent Event;

	private void OnCollisionEnter(Collision other)
	{
		if (other.collider)
		{
			Event.Invoke();
			Debug.Log("OOOOOOOOOAAHHHHHHH");
		}
	}
}
