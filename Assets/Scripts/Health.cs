using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {
    public float CurrentHealth { get; private set; }
    private float MaxHealth = 1000f;

    private void Start() {
        CurrentHealth = MaxHealth;
    }

    public void ReceiveDamage(float IncomingDamage) {
        CurrentHealth -= IncomingDamage;

        if (CurrentHealth <= 0) {
            Die();
        }
    }

    public void ReceiveHealing(float IncomeingHealing) {
        CurrentHealth += IncomeingHealing;

        if (CurrentHealth > MaxHealth)
            CurrentHealth = MaxHealth;
    }

    private void Die() {

        SceneManager.LoadScene("Game");
    }
}

