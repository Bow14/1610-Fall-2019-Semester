using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
	//This is a unity tutorial with scopes and modifiers 
	public int apples;

	public int bananas;

	private int stapler;

	private int sellotape;

	public void FruitMachine(int a, int b)
	{
		int answer;
		answer = a = b;
		Debug.Log("Frut total:" + answer);
	}

	private void OfficeSort(int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Office Supplies Total:" + answer);
	}
}
