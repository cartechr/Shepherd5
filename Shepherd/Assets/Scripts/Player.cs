using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool followplayer = true;
    public NPC_Follow check;
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (followplayer == true && check.sheepwithplayer == true)
            {
                followplayer = false;
                Debug.Log("Stop Following Player");
            }
            if (followplayer == false && check.sheepwithplayer == true)
            {
                followplayer = true;
                Debug.Log("Follow Player");
            }
        }
    }
}
