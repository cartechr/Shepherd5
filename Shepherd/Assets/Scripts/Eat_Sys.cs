using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat_Sys : MonoBehaviour
{
    public bool eating = false;
    public float EatTime = 10f;
    bool foodtimer = false;
    //food
    public NPC_Follow f;

    private void Start()
    {
        Debug.Log("Eating Time: " + EatTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sheep"))
        {
            Debug.Log("Sheep are eating");
            eating = true;
            foodtimer = true;
        }
    }
    private void Update()
    {
        if (foodtimer == true)
        {
            EatTime -= Time.deltaTime;
            if (EatTime <= 0)
            {
                foodtimer = false;
                EatTime = 0;
                
            }
        }
    }
}
