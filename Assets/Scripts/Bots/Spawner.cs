using System;
using UnityEngine;

public class Spawner : MonoBehaviour {
    private float timeBetweenSpawning = 10f;
    public GameObject robotPrefab;

    void Start() {
        InvokeRepeating("SpawnRobot", 2f, timeBetweenSpawning);
    }
    void SpawnRobot() {
        GameObject robot = Instantiate(robotPrefab) as GameObject;
        robot.transform.position = transform.position;
    }
}
