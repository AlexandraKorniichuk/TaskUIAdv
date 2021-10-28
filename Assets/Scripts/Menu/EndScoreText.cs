using UnityEngine;
using UnityEngine.UI;

public class EndScoreText : MonoBehaviour {
    private float score;
    private void Awake() {
        score = PlayerPrefs.GetFloat("Score");
    }
    void Start() {
        gameObject.GetComponent<Text>().text = $"Score: {score}";
    }
}
