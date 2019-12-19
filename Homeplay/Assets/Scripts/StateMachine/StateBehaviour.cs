using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StateBehaviour : StateMachineBehaviour
{

	public UnityEvent startEnterEvent, stateUpdateEvent, stateExitEvent;

	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		startEnterEvent.Invoke();
	}

	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		stateUpdateEvent.Invoke();
	}
	
	//OnStateExit is called when a transition ends and the state machine finishes evaluatiing this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		stateExitEvent.Invoke();
	}
	
	//OnStateMove is called right after Animator.OnAnimationMove()
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	//{
	// implement code that proceses and affects root motion
	//}
	
	// OnStateIK is called right after animator.OnAnimatorIK()
	//Override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	//{
	// implent code that sets up animation IK  (inverse kinematics)
	//}
}
