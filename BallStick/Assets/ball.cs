using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ball : MonoBehaviour
{
   Rigidbody rb;


   int[] randomX = new int[] {-3, 3};
   int[] randomY = new int[] {-15, 15};


    void Start()
    {             
        rb = GetComponent<Rigidbody>();

        int randomizeX = Random.Range(0, 2);
        int randomizeY = Random.Range(0, 2);

        rb.velocity = new Vector3(randomX[randomizeX], randomY[randomizeY], 0);
        print("randomx " + randomizeX);
        print("randomy " + randomizeY);
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
           
        }
    }

    private void FixedUpdate()
    {
      
    }
}
