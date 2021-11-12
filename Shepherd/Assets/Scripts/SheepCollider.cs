using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepCollider : MonoBehaviour
{
    //public Player_Position location;
    public Sheep_Transform sheep;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Sheep"))
        {
            Debug.Log("Success");
            //sheep.sheep_infinite();
        }
    }
}
