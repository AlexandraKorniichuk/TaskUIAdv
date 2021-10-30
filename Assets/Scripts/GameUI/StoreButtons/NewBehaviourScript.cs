using UnityEngine.UI;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public Sprite img;
    public Sprite img1;
    private Image buttonImage;
    public float priceOfButton;
    private float score;
    public GameObject bulletPrefab;
    private Shooting shootingScript;
    void Start() {
        buttonImage = gameObject.GetComponent<Image>();

        GameObject scoreCounter = GameObject.Find("ScoreCounter");
        score = scoreCounter.GetComponent<Score>().score;

        GameObject cameraPlayer = GameObject.FindGameObjectWithTag("MainCamera");
        shootingScript = cameraPlayer.GetComponent<Shooting>();
    }
    public void ChangeImage() {
        if (buttonImage.sprite == img)
            TurnOnButton();
    }
    public void TurnOnButton() {
        if (priceOfButton <= score) {
            buttonImage.sprite = img1;
            shootingScript.ChangeBullet(bulletPrefab);
        }
    }
}
