using UnityEngine;
using UnityEngine.UI;

public class StoreButton : MonoBehaviour {
    public Sprite img;
    public Sprite img1;
    private Image buttonImage;

    public float priceOfButton;
    private Score score;
    private ScoreText scoreText;
    public GameObject PriceText;
    private PriceText priceText;

    public GameObject bulletPrefab;
    private Shooting shootingScript;

    public GameObject LockImage;
    public bool isMainBullet;

    private Store store;

    void Start() {
        buttonImage = gameObject.GetComponent<Image>();

        GameObject scoreCounter = GameObject.Find("ScoreCounter");
        score = scoreCounter.GetComponent<Score>();
        scoreText = GameObject.Find("ScoreText").GetComponent<ScoreText>();
        priceText = PriceText.GetComponent<PriceText>();

        GameObject cameraPlayer = GameObject.FindGameObjectWithTag("MainCamera");
        shootingScript = cameraPlayer.GetComponent<Shooting>();

        if (isMainBullet)
            LockImage.SetActive(false);

        store = GameObject.Find("StoreUI").GetComponent<Store>();
    }
    public void ChangeImage() {
        if (buttonImage.sprite == img)
            TurnOnButton();
    }
    public void TurnOnButton() {
        if (priceOfButton <= score.score) {
            LockImage.SetActive(false);
            buttonImage.sprite = img1;

            shootingScript.ChangeBullet(bulletPrefab);

            score.ChangeScore(-priceOfButton);
            scoreText.ChangeScoreText(score.score);

            priceOfButton = 0;
            priceText.ChangePriceText(priceOfButton);

            store.ButtonManager(gameObject);
        }
    }
    public void TurnOffButton() {
        buttonImage.sprite = img;
    }
}
