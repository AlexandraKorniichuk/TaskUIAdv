using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {
    private void Start() {
        GameObject scoreCounter = GameObject.Find("ScoreCounter");
        float score = scoreCounter.GetComponent<Score>().score;
        gameObject.GetComponent<Text>().text = $"{score}";
    }
    public void ChangeScoreText(float score) {
        gameObject.GetComponent<Text>().text = $"{score}";
    }
}
