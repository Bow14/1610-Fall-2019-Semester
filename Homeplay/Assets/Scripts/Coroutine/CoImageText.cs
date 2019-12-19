using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class CoImageText : MonoBehaviour {
	
	private Text countText;
	public UnityEvent down;

	private void Update()
	{
		down.Invoke();
	}

	public void UpdateText(intData data)
	{
		countText.text = data.value.ToString();
	}

	void Awake ()
	{
		countText = GetComponent<Text>();

	}
	
}
