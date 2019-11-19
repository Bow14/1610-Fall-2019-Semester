using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public SpriteRenderer rend;
    
    public void DisplayWeapon(WeaponData weaponData)
    {
        rend.sprite = weaponData.sprite;
    }

}
