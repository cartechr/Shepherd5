using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_Follow : MonoBehaviour
{
    //Transform that NPC has to follow
    public Transform transformToFollow;
    //NavMesh Agent variable
    NavMeshAgent agent;
    //bool to check if sheep should follow player or not
    public Player follow;
    //bool to check if sheep are eating
    public Eat_Sys eat;
    public Water_Sys drink;
    public Sheep1Health sheep1health;
    public bool Starving = false;
    public bool Thirsty = false;
    public bool Dead = false;
    [Tooltip("Amount of food left")]
    public int food = 100;
    [Tooltip("Health Capacity of Food")]
    public int max_food_cap = 150;
    [Tooltip("Amount of thirst")]
    public int water = 100;
    [Tooltip("Health Capacity of Water")]
    public int max_water_cap;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (water >= 40 || food >= 80)
        {
            //checks if sheep should follow player or not
            if (follow.followplayer == true)
            {
                //Follow the player
                agent.destination = transformToFollow.position;
                agent.isStopped = false;
            }
            if (follow.followplayer == false)
            {
                agent.isStopped = true;
            }
        }
    }

    public void GetFood(GameObject FoundFood, float distance)
    {
        if (food <= 80 && drink.drinking == false)
        {
            agent.destination = FoundFood.transform.position;
        }
    }
    public void IncreaseHunger()
    {
        if (eat.eating == false)
        {
            food--;
            if (food < 0)
                food = 0;

            if (food == 0)
            {
                Starving = true;
            }
            //if (sheep1health.currentHealth == 0)
            // {
            //     Dead = true;
            // }
        }
    }

    public void GetWater(GameObject FoundWater, float distance)
    {
        if (water <= 40 && eat.eating == false)
        {
            agent.destination = FoundWater.transform.position;
        }
    }

    public void IncreaseWater()
    {
        if (drink.drinking == false)
        {
            water--;
            if (water < 0)
                water = 0;

            if (water == 0)
            {
                Thirsty = true;
            }

            //this will affect the sheep stamina
            //if (sheep1health.currentHealth == 0)
            // {
            //     Dead = true;
            // }
        }
    }
}


// https://sharpcoderblog.com/blog/npc-follow-player-in-unity-3d //

