using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    [SerializeField] float rotateSpd = 10f;
    [SerializeField] float moveSpd = 8f;

    [SerializeField] float maxXRange = 6.5f;


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
        //float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, 0);
        Vector3 velocity = movement * moveSpd;

        rbpaddle.velocity = velocity;
        

        Vector3 xpos = transform.position;
        xpos.x = Mathf.Clamp(xpos.x, -maxXRange, maxXRange);
        transform.position = xpos;

        //clamping
        /*if(transform.position.x <= -maxXRange)
        {
            transform.position = new Vector3(-maxXRange, transform.position.y, transform.position.z);
        } else if(transform.position.x >= maxXRange)
        {
            transform.position = new Vector3(maxXRange, transform.position.y, transform.position.z);
        }*/
        
        
    }
}
