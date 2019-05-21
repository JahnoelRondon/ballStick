using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float rotateSpd = 10f;
    [SerializeField] float moveSpd = 8f;

    Rigidbody rbpaddle;

    void Start()
    {
        rbpaddle = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
       
        

        //move
        //float horizontalinput = Input.GetAxis("Horizontal");
        //float verticalinput = Input.GetAxis("Vertical");
        //left right
        //transform.Translate(Vector3.right * horizontalinput * moveSpd * Time.deltaTime, Space.Self);
        //up down
        //transform.Translate(Vector3.up * verticalinput * moveSpd * Time.deltaTime, Space.Self);

        

    }

    private void FixedUpdate()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0);
        Vector3 velocity = movement * moveSpd;

        rbpaddle.velocity = velocity;
        
    }
}
