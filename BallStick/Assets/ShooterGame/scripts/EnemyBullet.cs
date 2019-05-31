using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] float bulletspeed = 10f;
    private Transform player;
    private Vector3 playerPosAtTheTime;

    [SerializeField] GameObject enemyparticle;


    private void Start()
    {
        player = GameObject.Find("PlayerShooter").GetComponent<Transform>();

        playerPosAtTheTime = new Vector3(player.transform.position.x, player.transform.position.y,
            player.transform.position.z);
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosAtTheTime, bulletspeed * Time.deltaTime);

        if(transform.position.x == playerPosAtTheTime.x && transform.position.y == playerPosAtTheTime.y &&
            transform.position.z == playerPosAtTheTime.z)
        {
            var enemyParticle = Instantiate(enemyparticle, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            

        }
    }
}
