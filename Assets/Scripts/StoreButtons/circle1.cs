using UnityEngine;

public class circle1 : MonoBehaviour {
    public GameObject circle;
    public void ChangeButton() {
        gameObject.SetActive(false);
        circle.SetActive(true);
    }
}