using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat_Sys : MonoBehaviour
{
    public bool eating = false;
    //food
    public NPC_Follow f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sheep"))
        {
            Debug.Log("Sheep are eating");
            eating = true;
            f.food += 1;
        }
    }
}
