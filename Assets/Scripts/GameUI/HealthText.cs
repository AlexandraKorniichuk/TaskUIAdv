using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour {
    public GameObject healthText;
    private void Awake() {
        healthText = GameObject.Find("HealthText");
    }
    public void ChangeHealthText(float health) {
        healthText.GetComponent<Text>().text = $"{health}";
    }
}
