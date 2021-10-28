using UnityEngine;

public class Bot : MonoBehaviour {
    private GameObject player;
    private float damage;
    private void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
        damage = 8f;
    }
    private void OnCollisionEnter(Collision collision) {
        GameObject Target = collision.gameObject;
        if (Target == GameObject.FindGameObjectWithTag("Player")) {
            player.GetComponent<Health>().ReceiveDamage(damage);
            DestroyRobot();
        }
    }

    private void DestroyRobot() {
        Destroy(gameObject);
    }
}

