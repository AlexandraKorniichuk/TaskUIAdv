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
    }
}
