using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoRoutines : MonoBehaviour
{
	public UnityEvent starEvent, repeatEvent, endEvent;

	public float seconds = 10f;

	public int counter = 3;
	private WaitForSeconds wfsobj;
	public bool canRun;

	private void Awake()
	{
		wfsobj = new WaitForSeconds(seconds);
	}

	public void CallCoroutine()
	{
		StartCoroutine(RunCoroutine());
	}

	// Use this for initialization
	IEnumerator RunCoroutine()
	{
		starEvent.Invoke();
		while (counter> 0)
		{
			repeatEvent.Invoke();
			yield return wfsobj;
			counter--;
		}

		while (canRun)
		{
			repeatEvent.Invoke();
			yield return wfsobj;
			counter--;

			endEvent.Invoke();
		}
	}
	




}
