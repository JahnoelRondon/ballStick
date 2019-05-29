using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForce : MonoBehaviour
{  
    
    Rigidbody rbpaddle;

    void Start()
    {
        rbpaddle = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        //no other force can push this gameObject
        rbpaddle.velocity = new Vector3(0,0,0);
        
    }
}
