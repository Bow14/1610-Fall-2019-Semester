using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
	public UnityEvent Startevent;
	// Use this for initialization
	void Start () 
	{
		Startevent.Invoke();
		
	}
	
	
}
