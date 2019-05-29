using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    //other objects & prefabs
    [SerializeField] GameObject enemyBulletPrefab;

    //parameter
    [SerializeField] float spd = 30f;
    [SerializeField] float stopingDistance = 4.5f;
    [SerializeField] float retreatDist = 3f;
    

    [SerializeField] float fireRate = 1f;
    [SerializeField] float nextFire = 0.0f;

    //components
    private Transform target;
    Rigidbody rb;

    private void Start()
    {
        target = GameObject.Find("PlayerShooter").GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Time.time > nextFire)
        {
            var enBullet = Instantiate(enemyBulletPrefab, this.transform.position, Quaternion.identity);
            
            nextFire = Time.time + fireRate;
        }
        
        
        
    }

    private void FixedUpdate()
    {
        //if the distance is greater than 10 follow the player
        if (Vector3.Distance(transform.position, target.position) > stopingDistance)
        {
            Vector3 movement = Vector3.MoveTowards(transform.position, target.position, spd * Time.deltaTime);
            transform.position = movement;       
           //else if the first statement is false check if the distance is less than 10 and greater than 5 stay still

        } else if(Vector3.Distance(transform.position, target.position) < stopingDistance && 
            Vector3.Distance(transform.position, target.position) > retreatDist)
        {
            transform.position = this.transform.position;

        }//else if first two statements are false check if the distance is less than 5 and move away from the player
        else if(Vector3.Distance(transform.position, target.position) < retreatDist)
        {
            print("run");
            Vector3 movement = Vector3.MoveTowards(transform.position, target.position, -spd * Time.deltaTime);
            transform.position = movement;
        }


    }
}
