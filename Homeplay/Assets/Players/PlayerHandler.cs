using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerHandler : ScriptableObject
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
