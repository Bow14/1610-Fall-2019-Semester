using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControl : MonoBehaviour
{

	public ParticleSystem particles;

	public void OnMouseDown()
	{
		particles.Emit(300);
	}
}
