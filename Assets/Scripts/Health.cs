using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {
    public float CurrentHealth { get; private set; }
    private float MaxHealth = 100f;
    private string dieText;

    private void Start() {
        CurrentHealth = MaxHealth;
    }

    public void ReceiveDamage(float IncomingDamage) {
        CurrentHealth -= IncomingDamage;
        if (CurrentHealth <= 0) {
            Die();
        }
    }

    private void Die() {
        dieText = "They killed you";
        SceneManager.LoadScene("EndGame");
    }
}

