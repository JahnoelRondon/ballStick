using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] float movespd = 8f;
    Rigidbody rb;

    shake shake;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        shake = GameObject.Find("ShakeManager").GetComponent<shake>();
        //or
        //shake = GameObject.FindGameObjectWithTag("screenShake").GetComponent<shake>();
    }


    private void FixedUpdate()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0);
        Vector3 velocity = movement * movespd;

        rb.velocity = velocity;
        

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("shoot");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print("wall trigger");
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("wall collider");
        shake.shaking();
    }

}
