﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class DataPlayer : GameArtData
{

	
	public List<WeaponData> weapons;
	public Powerups health;

	public ClothesData pants;
	public ClothesData shirt;
	public ClothesData boots;
	public void InstancePlayer()
	{
		var  newPlayer = Instantiate(prefab);
		var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
		newSprite.color = color;
		newSprite.sprite = sprite;
		
	}
}

