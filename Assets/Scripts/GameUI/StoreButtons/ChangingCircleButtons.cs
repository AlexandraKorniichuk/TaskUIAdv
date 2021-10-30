﻿using UnityEngine;

public class ChangingCircleButtons : MonoBehaviour {
    public GameObject notSelectedButton;
    public GameObject selectedButton;
    public GameObject bulletPrefab;
    private float score;
    private void Start() {
        GameObject scoreCounter = GameObject.Find("ScoreCounter");
        score = scoreCounter.GetComponent<Score>().score;
    }
    public void ChangeButton() {
        if (notSelectedButton.activeSelf)
            TurnOnButton();
    }
    public void TurnOnButton() {

        notSelectedButton.SetActive(false);
        selectedButton.SetActive(true);
    }
}
