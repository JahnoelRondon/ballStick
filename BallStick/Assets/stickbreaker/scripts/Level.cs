using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakables;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        if(breakables < 1)
        {
            print("you win");
            //load next level
        }
    }

    public void countBreakables()
    {
        breakables++;
    }

    public void reduceBreakableNumber()
    {
        breakables--;
    }
}
