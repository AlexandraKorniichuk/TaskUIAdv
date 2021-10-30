using UnityEngine;
using UnityEngine.UI;

public class StoreButton : MonoBehaviour {
    public Sprite img;
    public Sprite img1;
    private Image buttonImage;

    public float priceOfButton;
    private float score;

    public GameObject bulletPrefab;
    private Shooting shootingScript;

    public GameObject LockImage;
    public bool isMainBullet;

    void Start() {
        buttonImage = gameObject.GetComponent<Image>();

        GameObject scoreCounter = GameObject.Find("ScoreCounter");
        score = scoreCounter.GetComponent<Score>().score;

        GameObject cameraPlayer = GameObject.FindGameObjectWithTag("MainCamera");
        shootingScript = cameraPlayer.GetComponent<Shooting>();

        if (isMainBullet) 
            LockImage.SetActive(false);
    }
    public void ChangeImage() {
        if (buttonImage.sprite == img)
            TurnOnButton();
    }
    public void TurnOnButton() {
        if (priceOfButton <= score) {
            LockImage.SetActive(false);
            buttonImage.sprite = img1;
            shootingScript.ChangeBullet(bulletPrefab);
            score -= priceOfButton;
            priceOfButton = 0;
        }
    }
}
