using UnityEngine;

public class circle : MonoBehaviour {
    public GameObject circle1;
    public void ChangeButton() {
        circle1.SetActive(true);
        gameObject.SetActive(false);
    }
}
