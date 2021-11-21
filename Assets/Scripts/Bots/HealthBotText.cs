using UnityEngine;
using UnityEngine.UI;

public class HealthBotText : MonoBehaviour
{
    private TextMesh text;
    private void Start() {
        text = gameObject.GetComponent<TextMesh>();
    }
    public void ChangeText(float health)
    {
        text.text = $"{health}";
    }
}
