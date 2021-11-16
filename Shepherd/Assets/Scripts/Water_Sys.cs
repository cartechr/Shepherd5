using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Sys : MonoBehaviour
{
    public bool drinking = false;

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Sheep are drinking");
        drinking = true;
    }
}