using UnityEngine;

public class Score : MonoBehaviour {
    private float score = 0f;
    private ScoreText scoreText;
    private void Awake() {
        if (!PlayerPrefs.HasKey("Score")) {
            PlayerPrefs.SetFloat("Score", score);
        } else {
            score = PlayerPrefs.GetFloat("Score");
        }
        scoreText = GetComponent<ScoreText>();
        scoreText.ChangeScoreText(score);
    }
    public void ChangeScore() {
        score++;
        scoreText.ChangeScoreText(score);
    }

    public void SaveScore() {
        PlayerPrefs.SetFloat("Score", score);
    }
}
