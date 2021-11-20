using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Sys : MonoBehaviour
{
    public bool drinking = false;
    public float WaterTime = 10f;
    bool watertimer = false;
    public NPC_Follow checkfordrinking;

    private void Start()
    {
        Debug.Log("Drinking Time: " + WaterTime);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Sheep are drinking");
        if (checkfordrinking.water == 80)
        {
            drinking = true;
            watertimer = true;
        }
    }

    private void Update()
    {
        if (watertimer == true)
        {
            WaterTime -= Time.deltaTime;
            if (WaterTime <= 0)
            {
                watertimer = false;
                WaterTime = 0;
            }
        }
    }
}