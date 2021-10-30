using UnityEngine;

public class Score : MonoBehaviour {
    public float score = 0f;
    private ScoreText scoreText;
    private void Awake() {
        if (!PlayerPrefs.HasKey("Score")) {
            PlayerPrefs.SetFloat("Score", score);
        } else {
            score = PlayerPrefs.GetFloat("Score");
        }
        scoreText = GameObject.Find("ScoreText").GetComponent<ScoreText>();
    }
    private void Start() {
        scoreText.ChangeScoreText(score);
    }
    public void ChangeScore(float numberOfChangingScore) {
        score += numberOfChangingScore;
        scoreText.ChangeScoreText(score);
    }

    public void SaveScore() {
        PlayerPrefs.SetFloat("Score", score);
    }
}
