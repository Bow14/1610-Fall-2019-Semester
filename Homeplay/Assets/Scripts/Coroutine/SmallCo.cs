using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCo : MonoBehaviour
{
	public bool canRun = true;
	public intData index;
	public WaitForSeconds wfsobj;
	public float seconds = 1f;
	

	public void Run()
	{
		StartCoroutine(onRun());
		wfsobj = new WaitForSeconds(seconds);
	}

	IEnumerator onRun() {
		while (index.value > 0)
		{
			index.value--;
			yield return new WaitForSeconds(1f);
			
		}
		
	}
	
}
