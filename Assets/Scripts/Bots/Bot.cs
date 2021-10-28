using UnityEngine;

public class Bot : MonoBehaviour {
    private GameObject player;
    private Health healthScript;
    private float damage = 8f;
    private void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
        healthScript = player.GetComponent<Health>();
    }
    private void OnCollisionEnter(Collision collision) {
        GameObject Target = collision.gameObject;
        if (Target == player) {
            healthScript.ReceiveDamage(damage);
            DestroyRobot();
        }
    }

    private void DestroyRobot() {
        Destroy(gameObject);
    }
}

