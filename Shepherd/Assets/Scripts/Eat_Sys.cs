using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat_Sys : MonoBehaviour
{
    public bool eating = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Food Detected Player");
            eating = true;
        }
    }
}