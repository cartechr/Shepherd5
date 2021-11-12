using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] List<NPC_Follow> Sheep;
    [SerializeField] List<GameObject> Food;
    [SerializeField] List<GameObject> Water;
    static GameController _instance;
    //Reference to npc_follow
    public NPC_Follow sheepfd;
    [Tooltip("Rate in seconds in which the hunger increases")]
    public float HungerRate = 0.5f;
    public float WaterRate = 0.5f;

    

    public Sheep1Health sheep1health;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        InvokeRepeating("IncreaseHunger", 0, HungerRate);
        InvokeRepeating("IncreaseWater", 0, WaterRate);

    }

    public void IncreaseHunger()
    {
        for (int i = 0; i < Sheep.Count; i++)
        {
            Sheep[i].IncreaseHunger();
        }
    }
    public void IncreaseWater()
    {
        for (int i = 0; i < Sheep.Count; i++)
        {
            Sheep[i].IncreaseHunger();
        }
    }

    void SheepFood()
    {
        for (int i = 0; i < Sheep.Count; i++)
        {
            float distance = float.MaxValue;
            int closestFoodID = -1;

            for (int j = 0; j < Food.Count; j++)
            {
                float dist = Vector3.Distance(Sheep[i].transform.position, Food[j].transform.position);
                if (dist < distance)
                {
                    distance = dist;
                    closestFoodID = j;
                }
            }

            if (closestFoodID != -1)
            {

                Sheep[i].GetFood(Food[closestFoodID], distance);
            }
        }
    }

    void SheepWater()
    {
        for (int i = 0; i < Sheep.Count; i++)
        {
            float distance = float.MaxValue;
            int closestWaterID = -1;

            for (int j = 0; j < Water.Count; j++)
            {
                float dist = Vector3.Distance(Sheep[i].transform.position, Water[j].transform.position);
                if (dist < distance)
                {
                    distance = dist;
                    closestWaterID = j;
                }
            }

            if (closestWaterID != -1)
            {

                Sheep[i].GetWater(Water[closestWaterID], distance);
            }
        }
    }
    private void Update()
    {
        SheepFood();
        SheepWater();
    }
}
