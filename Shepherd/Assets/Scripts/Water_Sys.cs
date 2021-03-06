using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Sys : MonoBehaviour
{
    public bool drinking = false;
    public float WaterTime = 10f;
    bool watertimer = false;

    private void Start()
    {
        Debug.Log("Drinking Time: " + WaterTime);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Sheep are drinking");
        drinking = true;
        watertimer = true;
    }

    private void Update()
    {
        if (watertimer == true)
        {
            WaterTime -= Time.deltaTime;
            if (WaterTime <= 0)
            {
                drinking = false;
                watertimer = false;
                WaterTime = 0;
            }
        }
    }
}