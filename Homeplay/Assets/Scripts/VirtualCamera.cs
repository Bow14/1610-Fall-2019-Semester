using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
[RequireComponent(typeof(CinemachineVirtualCamera))]
public class VirtualCamera : MonoBehaviour
{
	public DataPlayer dataPlayer;

	private void InstanceHandler(GameObject obj)
	{
		virtualCamera.Follow = obj.transform;
	}

	private CinemachineVirtualCamera virtualCamera;
	// Use this for initialization
	void Awake ()
	{
		virtualCamera = GetComponent<CinemachineVirtualCamera>();
		dataPlayer.instanceAction = InstanceHandler;
		dataPlayer.InstancePlayer();
	}
	
	
}
