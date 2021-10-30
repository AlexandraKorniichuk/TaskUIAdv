using UnityEngine;

public class Store : MonoBehaviour {
    private GameObject buttonCircle;
    private GameObject buttonSquare;
    private GameObject buttonPumpkin;
    private StoreButton buttonCircleScript;
    private StoreButton buttonSquareScript;
    private StoreButton buttonPumpkinScript;
    private void Start() {
        buttonCircle = GameObject.Find("buttonCircle");
        buttonSquare = GameObject.Find("buttonSquare");
        buttonPumpkin = GameObject.Find("buttonPumpkin");
        buttonCircleScript = buttonCircle.GetComponent<StoreButton>();
        buttonSquareScript = buttonSquare.GetComponent<StoreButton>();
        buttonPumpkinScript = buttonPumpkin.GetComponent<StoreButton>();
    }
    public void ButtonManager(GameObject changingButton) {
        if (buttonCircle == changingButton) {
            buttonSquareScript.TurnOffButton();
            buttonPumpkinScript.TurnOffButton();
        } else if (buttonSquare == changingButton) {
            buttonCircleScript.TurnOffButton();
            buttonPumpkinScript.TurnOffButton();
        } else if (buttonPumpkin == changingButton) {
            buttonCircleScript.TurnOffButton();
            buttonSquareScript.TurnOffButton();
        }
    }    
}
