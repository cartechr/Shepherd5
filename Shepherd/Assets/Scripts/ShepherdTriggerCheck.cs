using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShepherdTriggerCheck : MonoBehaviour
{
    private Coyote_Wander coyote;
    // Start is called before the first frame update

    private void Awake()
    {
        coyote = GameObject.Find("Coyote_NPC").GetComponent<Coyote_Wander>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ScatterTrigger")
        {
            coyote.Howl();
        }
    }
}
