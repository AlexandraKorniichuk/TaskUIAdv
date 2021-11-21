using UnityEngine;

public class Bot : MonoBehaviour {
    private GameObject player;
    private Health healthScript;

    public GameObject healthText;
    private HealthBotText botText;

    public float health { get; private set; }
    private float damageForPlayer = 8f;
    private void Awake() {
        health = 3f;
        player = GameObject.FindGameObjectWithTag("Player");
        healthScript = player.GetComponent<Health>();
        botText = healthText.GetComponent<HealthBotText>();
    }
    private void OnCollisionEnter(Collision collision) {
        GameObject Target = collision.gameObject;
        if (Target == player) {
            healthScript?.ReceiveDamage(damageForPlayer);
        }
    }

    public void ReceiveDamage(float incomingDamage) {
        health -= incomingDamage;
        botText.ChangeText(health);
        if (health <= 0) {
            DestroyRobot();
        }
    }

    private void DestroyRobot() {
        Destroy(gameObject);
    }
}

