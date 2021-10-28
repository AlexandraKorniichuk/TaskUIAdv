using System;
using UnityEngine;

public class Spawner : MonoBehaviour {
    private float timeBetweenSpawning = 10f;
    public GameObject robotPrefab;

    private BotMovement botMovement;
    private float influxCounter = 1f;

    void Start() {
        botMovement = GetComponent<BotMovement>();
        InvokeRepeating("SpawnRobot", 2f, timeBetweenSpawning);
    }
    void SpawnRobot() {
        GameObject robot = Instantiate(robotPrefab) as GameObject;
        robot.transform.position = transform.position;
        influxCounter += 1f;
        botMovement.ChangeSpeed(influxCounter);
    }
}
