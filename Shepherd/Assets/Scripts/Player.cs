using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool followplayer = true;
    //public NPC_Follow check;
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Pressed F");
            // Toggle for followplayer.
            followplayer = !followplayer;
        }
    }
}
