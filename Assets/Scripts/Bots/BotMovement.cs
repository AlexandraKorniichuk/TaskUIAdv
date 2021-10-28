using UnityEngine;

public class BotMovement : MonoBehaviour {
    private GameObject player;
    public float speed = 4f;
    private void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update() {
        transform.LookAt(player.transform);
        transform.position += transform.forward * Time.deltaTime * speed;
    }
}
