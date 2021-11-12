using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol_NPC : StateMachineBehaviour
{
    GameObject Coyote_NPC;
    GameObject[] waypoints;
    int currentWP;

    void Awake()
    {
        waypoints = GameObject.FindGameObjectsWithTag("waypoint");
    }

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Coyote_NPC = animator.gameObject;
        currentWP = 0;
    }

    //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (waypoints.Length == 0) return;
        if (Vector3.Distance(waypoints[currentWP].transform.position, Coyote_NPC.transform.position) < 3.0f)
        {
            currentWP++;
            if (currentWP >= waypoints.Length)
            {
                currentWP = 0;
            }
        }
        //agent.SetDestination(waypoints[currentWP].transform.position);
        //rotation to target
        var direction = waypoints[currentWP].transform.position - Coyote_NPC.transform.position;
        Coyote_NPC.transform.rotation = Quaternion.Slerp(Coyote_NPC.transform.rotation, Quaternion.LookRotation(direction),
            1.0f * Time.deltaTime);
        Coyote_NPC.transform.Translate(0, 0, Time.deltaTime * 2.0f);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
    

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
//https://www.youtube.com/watch?v=o011XuWOMmM 
