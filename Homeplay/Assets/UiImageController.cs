using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class UiImageController : MonoBehaviour
{

	private Image img;

	void Awake()
	{
		img = GetComponent<Image>();
	}

	public void UpateImage(Powerups data)
	{
		img.fillAmount = data.HealthAmount;
	}
	
}
