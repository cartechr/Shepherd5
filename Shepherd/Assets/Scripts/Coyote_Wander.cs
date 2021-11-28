using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Coyote_Wander : MonoBehaviour
{
    public Transform[] waypoints;
    public NavMeshAgent nav;
    int current = 0;
    int phase = 1;
    // Update is called once per frame
    void Update()
    {
        switch (phase)
        {
            case 1:
                // PHASE 1: Coyote on bridge
                Vector2 currentPos = new Vector2(transform.position.x, transform.position.z);
                Vector2 destination = new Vector2(waypoints[current].position.x, waypoints[current].position.z);
                float distance = Vector2.Distance(currentPos, destination);
                if (distance > 2)
                {
                    nav.SetDestination(waypoints[current].position);
                    Debug.Log("not met");
                }
                else
                {
                    if (current == 4) { current = 1; }
                    else current += 1;
                    Debug.Log("destination met");
                }
                break;
        }
    }

    void SetPhase(int phase)
    {
        //placeholder
    }
}
