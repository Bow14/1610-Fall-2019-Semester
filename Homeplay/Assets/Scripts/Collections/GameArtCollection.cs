
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
	public List<GameArtData> collectionList;

	public void AddData(GameArtData obj)
	{

		if (!collectionList.Contains(obj))
		{
			collectionList.Add(obj);
		}

	}
}
