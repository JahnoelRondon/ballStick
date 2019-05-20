using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float rotateSpd = 10f;
    [SerializeField] float moveSpd = 8f;

    void Start()
    {
        
    }

    
    void Update()
    {
        //float horizontalinput = Input.GetAxis("Horizontal");
        //float verticalinput = Input.GetAxis("Vertical");

        
        

        //move
        float horizontalinput = Input.GetAxis("Horizontal");
        float verticalinput = Input.GetAxis("Vertical");
        //left right
        transform.Translate(Vector3.right * horizontalinput * moveSpd * Time.deltaTime, Space.Self);
        //up down
        transform.Translate(Vector3.up * verticalinput * moveSpd * Time.deltaTime, Space.Self);

    }
}
