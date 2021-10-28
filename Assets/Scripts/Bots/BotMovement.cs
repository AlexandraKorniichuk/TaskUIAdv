﻿using UnityEngine;

public class BotMovement : MonoBehaviour {
    private GameObject player;
    private float speed = 8f;
    private void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update() {
        transform.LookAt(player.transform);
        transform.position += transform.forward * Time.deltaTime * speed;
    }
}