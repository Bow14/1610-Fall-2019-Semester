 
using UnityEngine;

public class Movement : MonoBehaviour
{


	public float speed  = 1f;
	private Vector3 position;
	public CharacterController controller;
	public float gravity = 3f;

	public float jumpspeed = 20f;
	void Update()
	{
		controller.Move(position *= Time.deltaTime);
		if (Input.GetButtonDown("Jump"))
		{
			position.y = jumpspeed;		
		}

		if (!controller.isGrounded)
		{
			position.y -= gravity;
		}	
		position.x = speed* Input.GetAxis("Horizontal");;
	}
}
