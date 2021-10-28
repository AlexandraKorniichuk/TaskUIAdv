using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {
    public GameObject textScore;
    private void Awake() {
        textScore = GameObject.Find("ScoreText");
    }
    public void ChangeScoreText(float score) {
        textScore.GetComponent<Text>().text = $"{score}";
    }
}
