using UnityEngine;

public class MouseLook : MonoBehaviour {
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float rotationX = 0f;
    private bool freezeCamera = false;

    public GameObject storeUI;
    public GameObject gameUI;

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update() {
        if (!freezeCamera)
            MoveCamera();
        ChangeStoreStatus();
    }
    private void MoveCamera() {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private void ChangeStoreStatus() {
        if (Input.GetKeyDown(KeyCode.E)) {
            if (storeUI.activeSelf == true) {
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
            } else {
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
            }
            storeUI.SetActive(!storeUI.activeSelf);
            gameUI.SetActive(!gameUI.activeSelf);
            freezeCamera = !freezeCamera;
        }
    }
}
