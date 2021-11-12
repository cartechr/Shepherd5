using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_Enemy_Script : MonoBehaviour
{
    public GameObject Coyote;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Coyote"))
        {
            Debug.Log("Detected Coyote");
            if(Input.GetMouseButtonDown(0))
            {
                Debug.Log("Kill Coyote");
                Coyote.SetActive(false);
            }

        }
    }
}
