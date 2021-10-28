using UnityEngine;

public class Bullet : MonoBehaviour {
    private GameObject player;
    private float force = 100f;
    private float damageBullet;
    private void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
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
        if (Target != GameObject.FindGameObjectWithTag("Player") && Target != GameObject.FindGameObjectWithTag("MainCamera")) {
            Destroy(Target);
        }

        if (Target.GetComponent<Health>() != null) {
            Target.GetComponent<Health>().ReceiveDamage(damageBullet);
        }
        DestroyBullet();
    }

    private void DestroyBullet() {
        Destroy(gameObject);
    }
}
