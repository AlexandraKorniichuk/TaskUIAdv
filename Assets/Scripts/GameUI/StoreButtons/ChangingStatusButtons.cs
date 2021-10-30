using UnityEngine;

public class ChangingStatusButtons : MonoBehaviour {
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
        else
            TurnOffButton();
    }
    public void TurnOnButton() {

    }
    public void TurnOffButton() {

    }
}
