using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject enemyBullet;

    public Transform SpawnBulletPoint;

    private Transform playerPosition;

    public float bulletVelocity = 100;

    void Start()
    {
        playerPosition = FindObjectOfType<PlayerController>().transform;

        Invoke("ShootPlayer",3);
    }

    
    void Update()
    {
        
    }


    void ShootPlayer()
    {
        Vector3 playerDirection = playerPosition.position - transform.position;

        GameObject newBullet;
        newBullet= Instantiate(enemyBullet, SpawnBulletPoint.position,SpawnBulletPoint.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(playerDirection*bulletVelocity,ForceMode.Force);
        Invoke("ShootPlayer", 3);
    }


}

