using UnityEngine;

public class Shooting : MonoBehaviour {
    public GameObject prefabOfBullet;
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            ShootByBullet();
        }
    }

    private void ShootByBullet() {
        GameObject bullet = Instantiate(prefabOfBullet, transform.position, transform.rotation);
        //Rigidbody rb = bullet.GetComponent<Rigidbody>();
        //if (rb != null) {
        //    Vector3 ShootDirection = Vector3.forward;
        //    rb.AddForce(ShootDirection.normalized);
        //}
    }
}
