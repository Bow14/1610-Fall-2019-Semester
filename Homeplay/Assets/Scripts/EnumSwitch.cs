using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Events;

public class EnumSwitch : MonoBehaviour {
	
	
	public enum States
	{
		Start,
		Playing,
		End
	}

	public States currentState;

	public UnityEvent OnStartEvent, OnPlayingEvent, OnEndEvent;

	// Update is called once per frame
	void Update () 
	{
		switch (currentState)
		{
			case States.Start:
				OnStartEvent.Invoke();
				break;
			case States.Playing:
				OnStartEvent.Invoke();
				break;
			case States.End:
				OnStartEvent.Invoke();
				break;
			default:
				throw new ArgumentOutOfRangeException();
		}	
	}
}
