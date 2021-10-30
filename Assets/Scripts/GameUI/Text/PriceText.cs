using UnityEngine;
using UnityEngine.UI;

public class PriceText : MonoBehaviour {
    public GameObject button;
    private void Start() {
        float price = button.GetComponent<StoreButton>().priceOfButton;
        gameObject.GetComponent<Text>().text = $"{price}";
    }
    public void ChangePriceText(float price) {
        gameObject.GetComponent<Text>().text = $"{price}";
    }
}