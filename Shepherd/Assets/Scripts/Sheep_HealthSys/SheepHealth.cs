using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SheepHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    private NavMeshAgent nav;


    // MAIN PROPERTIES
    public float sheepStamina;
    public float maxSheepStamina;
    [HideInInspector] public bool hasRegenerated = true;
    [HideInInspector] public bool moving = false;

    // REGEN PROPERTIES
    [Range(0, 50)] [SerializeField] private float staminaDrain;
    [Range(0, 50)] [SerializeField] private float staminaRegen;

    // SPEED PROPERTIES
    [SerializeField] private float slowedSpeed;
    [SerializeField] private float normalSpeed;

    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        nav.speed = normalSpeed;
    }
    void Start()
    {
        //currentHealth = maxHealth;
    }

    //void TakeDamage(int amount)
    //{
    //currentHealth -= amount;

    //if (currentHealth <= 0)
    //{
    ////ragdoll effect
    //}
    //}

    //public void Heal(int amount)
    //{
    //currentHealth += amount;

    //if (currentHealth > maxHealth)
    //{
    //currentHealth = maxHealth;
    //}

    //}

    private void Update()
    {
        if (!moving)
        {
            if (sheepStamina <= maxSheepStamina - 0.01)
            {
                sheepStamina += staminaRegen * Time.deltaTime;
                //UpdateStamina

                if (sheepStamina >= maxSheepStamina)
                {
                    //set to normal speed
                    hasRegenerated = true;
                }
            }
        }
        IsMoving();
        Moving();
        DetermineSpeed();
    }

    public void Moving()
    {
        if (hasRegenerated && moving)
        {
            sheepStamina -= staminaDrain * Time.deltaTime;
        }
    }

    public void IsMoving()
    {
        if (nav.isStopped)
        {
            moving = false;
        }
        else moving = true;
    }

    public void DetermineSpeed()
    {
        if (sheepStamina <= 0)
        {
            nav.speed = slowedSpeed;
        }
        else if (sheepStamina >= maxSheepStamina && hasRegenerated)
        {
            nav.speed = normalSpeed;
        }
    }

}
// https://www.youtube.com/watch?v=vNL4WYgvwd8&t=0s
// https://www.youtube.com/watch?v=Fs2YCoamO_U&ab_channel=SpeedTutor