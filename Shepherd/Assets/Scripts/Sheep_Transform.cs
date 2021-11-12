using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep_Transform : MonoBehaviour
{
    //movement speed in units per second
    //private float movementSpeed = 5f;
    public static int movespeed = 1;

    //public float sheep_vertical;
   // public Player_Position player_vertical;

    public Vector3 userDirection = Vector3.right;
    //public void Location()
   // {
      //  float move_to_this = player_vertical.verticalInput + sheep_vertical;
        //update the position
     //  transform.position = transform.position + new Vector3(move_to_this * movementSpeed * Time.deltaTime, 0);

        //output to log the position change
      // Debug.Log(transform.position);
   // }

    //public void sheep_infinite()
 //   {
      //  transform.Translate(userDirection * movespeed * Time.deltaTime);
        
    //}
}
