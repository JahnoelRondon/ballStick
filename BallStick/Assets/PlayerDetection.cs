using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{

    [SerializeField] GameObject DeathParticle;

    private void OnCollisionEnter(Collision other)
    {
           
           switch (other.collider.gameObject.tag)
           {
               case "Ball":
                   print("dead");
                   break;
           }       
       
    }

}
