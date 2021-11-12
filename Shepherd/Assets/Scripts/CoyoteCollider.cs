using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoyoteCollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sheep"))
        {

        }
    }
}
