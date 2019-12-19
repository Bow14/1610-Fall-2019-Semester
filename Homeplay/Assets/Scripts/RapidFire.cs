using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFire : MonoBehaviour
{
	public float holdTime = 1f;
	public WaitForSeconds waitForSeconds;
	public bool canRun;
	public GameAction gameActionObj;
	private void Awake()
	{
		waitForSeconds = new WaitForSeconds(holdTime);
	}

	private void OnMouseUp()
	{
		canRun = false;
	}

	private IEnumerator OnMouseDown()
	{
		canRun = true;
		while (true)
		{
			gameActionObj.Raise();
			yield return waitForSeconds;
		}
		
	}
}
