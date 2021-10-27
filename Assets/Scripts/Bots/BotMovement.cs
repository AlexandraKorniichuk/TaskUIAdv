using UnityEngine;

public class BotMovement : MonoBehaviour {
    public GameObject player;
    public float speed = 4f;

    void Update() {
        transform.LookAt(player.transform);
        transform.position += transform.forward * Time.deltaTime * speed;
    }
}
