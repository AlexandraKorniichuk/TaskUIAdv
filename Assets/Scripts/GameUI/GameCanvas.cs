using UnityEngine;
using TMPro;

public class GameCanvas : MonoBehaviour {
    public GameObject gameUI;
    public TextMeshProUGUI killingInfoTemplate;
    public void ShowKillInfo() {
        TextMeshProUGUI killingInfoClone = Instantiate(killingInfoTemplate);
        UITranslator.TranslateTextToUIPosition(killingInfoClone, killingInfoTemplate.GetComponent<RectTransform>(), gameUI);
        Destroy(killingInfoClone.gameObject, 4f);
    }
}