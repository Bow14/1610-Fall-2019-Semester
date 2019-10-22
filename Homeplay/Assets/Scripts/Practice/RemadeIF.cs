using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemadeIF : MonoBehaviour
{

	public bool mrbrightsideplaying, delusionplaying, sickflowplaying;
	// Use this for initialization
	void Start () {
		if (delusionplaying)
		{
			print("Hell ya *Headbangs*");
		}
		else if (mrbrightsideplaying)
		{
			print("Aww shit *Cries*");
		}
		else if (sickflowplaying)
		{
			print("Hmmmm *starts to fill with anger and pain");
		}
		else
		{
			print("Existence is not real");
		}
		
		}
	
	
}
