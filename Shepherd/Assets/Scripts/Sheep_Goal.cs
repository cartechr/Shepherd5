using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep_Goal : MonoBehaviour
{
    public Transform Goal;
    public float SpaceBetween;

    void Update()
    {
       // if (Sheep.SheepFood == true)
       // {

            if (Vector3.Distance(Goal.position, transform.position) >= SpaceBetween)
            {
                Vector3 direction = Goal.position - transform.position;
                transform.Translate(direction * Time.deltaTime);
            }
       // }
    }
}
