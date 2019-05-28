using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] float spd = 30f;
    private Transform target;
    Rigidbody rb;

    private void Start()
    {
        target = GameObject.Find("PlayerShooter").GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        

        if (Vector3.Distance(transform.position, target.position) < 10)
        {
            Vector3 movement = Vector3.MoveTowards(transform.position, target.position, spd * Time.deltaTime);
            transform.position = movement;
        } 
        
    }

    private void FixedUpdate()
    {
        //var pos = transform.position;
        
    }
}
