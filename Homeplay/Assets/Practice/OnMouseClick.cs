using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnMouseClick : MonoBehaviour
{

	public UnityEvent Click; 
	private void OnMouseDown()
	{
		Click.Invoke();
	}
}
