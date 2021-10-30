using UnityEngine;

public class Shooting : MonoBehaviour {
    public GameObject prefabOfBullet;
    public GameObject storeUI;
    private void Start() {
        
    }
    void Update() {
        if (!storeUI.activeSelf) {
            if (Input.GetMouseButtonDown(0)) {
                ShootByBullet();
            }
        }
    }

    private void ShootByBullet() {
        GameObject bullet = Instantiate(prefabOfBullet, transform.position, transform.rotation);
    }

    public void ChangeBullet(GameObject newBullet) {
        prefabOfBullet = newBullet;
    }
}
