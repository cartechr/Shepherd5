using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep_Food : MonoBehaviour
{
    public bool SheepFood = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sheep"))
        {
            SheepFood = true;
        }
    }
}
