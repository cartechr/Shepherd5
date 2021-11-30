using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep1Health : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;


    // MAIN FUNCTIONS
    public float sheep1Stamina = 200.0f;
    [SerializeField] private float maxsheep1Stamina = 200.0f;
    [HideInInspector] public bool hasRegenerated = true;
    [HideInInspector] public bool weareSprinting = false;

    // REGEN FUNCTIONS
    [Range(0, 50)] [SerializeField] private float staminaDrain = 0.5f;
    [Range(0, 50)] [SerializeField] private float staminaRegen = 0.5f;

    // SPEED FUNCTIONS
    [SerializeField] private int slowedSpeed = 4;
    [SerializeField] private int normalSpeed = 8;

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
        if (!weareSprinting)
        {
            if (sheep1Stamina <= maxsheep1Stamina - 0.01)
            {
                sheep1Stamina += staminaRegen * Time.deltaTime;
                //UpdateStamina

                if (sheep1Stamina >= maxsheep1Stamina)
                {
                    //set to normal speed
                    hasRegenerated = true;
                }
            }
        }
    }

    public void Sprinting()
    {
        if (hasRegenerated)
        {
            weareSprinting = true;
            sheep1Stamina -= staminaDrain * Time.deltaTime;

        }
    }

}
// https://www.youtube.com/watch?v=vNL4WYgvwd8&t=0s
// https://www.youtube.com/watch?v=Fs2YCoamO_U&ab_channel=SpeedTutor