using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Coyote_Script : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;
    int m_CurrentWaypointIndex;

    public Transform sheep;
    public bool sheeptarget = false;
    private void Start()
    {
        //navMeshAgent.SetDestination(waypoints[0].position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Sheep"))
        {
            Debug.Log("Detected Sheep");
            sheeptarget = true;
        }
    }
    private void Update()
    {
        if (sheeptarget == false)
        {
            if(navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
            {
                m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
                navMeshAgent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
                Debug.Log("Stay");
            }
        }
        if (sheeptarget == true)
        {
            navMeshAgent.SetDestination (sheep.position);
            Debug.Log("Go to Sheep");
        }

        
        //sheeptarget = false;
    }
}
