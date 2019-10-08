using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPlayer : GameArtData
{

	
	public WeaponData weapon;

	public void InstancePlayer()
	{
		var  newPlayer = Instantiate(prefab);
		var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
		newSprite.color = color;
		newSprite.sprite = sprite;
	}
}
