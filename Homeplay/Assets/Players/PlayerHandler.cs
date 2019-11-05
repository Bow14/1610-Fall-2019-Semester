using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{

	public void SwitchPlayer(DataPlayer data)
	{
		playerDataObj = data;
	}
	public DataPlayer playerDataObj;
	public void onRun () 
	{
		playerDataObj.Run();
	}
}
