using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ball : MonoBehaviour
{
   Rigidbody rb;


   int[] randomX = new int[] {-3, 3};
   int[] randomY = new int[] {-30, 30};
   bool hasStarted = true; 


    void Start()
    {             

        rb = GetComponent<Rigidbody>();

        
    }

    
    void Update()
    {
        startGame();

    }

    private void startGame()
    {
        if (hasStarted)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int randomizeX = Random.Range(0, 2);
                int randomizeY = Random.Range(0, 2);

                rb.velocity = new Vector3(randomX[randomizeX], randomY[randomizeY], 0);
                //print("randomx " + randomizeX);
                //print("randomy " + randomizeY);
                hasStarted = false;
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        switch (other.collider.gameObject.tag)
        {
            case "Finish":
                print("hit stick");
                break;
        }
    }
}
