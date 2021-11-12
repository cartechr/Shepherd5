using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox_Script : MonoBehaviour
{
    public bool targetsheep = false;
    public GameObject sheep;
    private void Update()
    {
        if (targetsheep == true)
        {
            this.transform.position = sheep.transform.position;
        }
    }
}
