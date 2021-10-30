using UnityEngine;

public class Bullet : MonoBehaviour {
    private GameObject player;
    private Score scoreScript;
    private float force = 5000f;
    private GameCanvas gameCanvasScript;
    private void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
        scoreScript = GameObject.Find("ScoreCounter").GetComponent<Score>();
        gameCanvasScript = GameObject.Find("GameUI").GetComponent<GameCanvas>();
    }
    private void Start() {
        Physics.IgnoreCollision(player.GetComponent<Collider>(), gameObject.GetComponent<Collider>());
        for (int i = 0; i < player.transform.childCount; i++) {
            if (player.transform.GetChild(i).GetComponent<Collider>() != null)
                Physics.IgnoreCollision(player.transform.GetChild(i).GetComponent<Collider>(), gameObject.GetComponent<Collider>());
        }
        FlyForward();
    }

    public void FlyForward() {
        Ray ray = new Ray();
        if (player.GetComponentInChildren<MouseLook>() != null) {
            GameObject playerCamera = player.GetComponentInChildren<MouseLook>().gameObject;
            ray.origin = playerCamera.transform.position;
            ray.direction = playerCamera.transform.forward;
        } else {
            ray.origin = player.transform.position;
            ray.direction = player.transform.forward;
        }

        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(ray.direction * force);
    }
    private void OnCollisionEnter(Collision collision) {
        GameObject Target = collision.gameObject;
        if (Target.tag == "Robot") {
            scoreScript.ChangeScore(1f);
            gameCanvasScript.ShowKillInfo();
            Destroy(Target);
            DestroyBullet();
        } else if (Target.tag == "Terrain") {
            DestroyBullet();
        }
    }

    private void DestroyBullet() {
        Destroy(gameObject);
    }
}
