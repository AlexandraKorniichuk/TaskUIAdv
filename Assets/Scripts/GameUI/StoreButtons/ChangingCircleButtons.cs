using UnityEngine;

public class ChangingCircleButtons : MonoBehaviour {
    public GameObject circle;
    public GameObject circle1;
    public void ChangeButton() {
        print("rrr");
        circle.SetActive(!circle.activeSelf);
        circle1.SetActive(!circle1.activeSelf);
    }
}
