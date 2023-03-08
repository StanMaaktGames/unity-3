using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    private Vector3 spawnPos = new Vector3(30, 2f, 0);
    private float startDelay = 3f;
    private float repeatDelay = 5f;
    private playerController playerControllerScript;

    void Start()
    {
        playerControllerScript = GameObject.Find("player").GetComponent<playerController>();
        InvokeRepeating("SpawnRandomObstacle", startDelay, repeatDelay);
    }

    void SpawnRandomObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
            Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);
        }
    }
}
