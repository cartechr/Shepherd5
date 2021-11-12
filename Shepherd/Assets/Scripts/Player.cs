using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool followplayer = true;
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (followplayer == true)
            {
                followplayer = false;
                Debug.Log("Stop Following Player");
            }
            else
            {
                followplayer = true;
                Debug.Log("Follow Player");
            }
        }
    }
}
