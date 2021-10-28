using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {
    public float currentHealth { get; private set; }
    private float MaxHealth = 1000f;
    private HealthText healthText;

    private void Start() {
        healthText = GetComponent<HealthText>();
        currentHealth = MaxHealth;
        healthText.ChangeHealthText(currentHealth);
    }

    public void ReceiveDamage(float incomingDamage) {
        currentHealth -= incomingDamage;
        healthText.ChangeHealthText(currentHealth);
        if (currentHealth <= 0) {
            Die();
        }
    }

    private void Die() {
        GameObject scoreCounter = GameObject.Find("ScoreCounter");
        Score score = scoreCounter.GetComponent<Score>();
        score.SaveScore();
        SceneManager.LoadScene("EndGame");
    }
}

