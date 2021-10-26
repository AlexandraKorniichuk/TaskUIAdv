using UnityEngine;
using UnityEngine.EventSystems;

public class ChangingScaleButtons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
    public Animator _animator;
    private void Awake() {
        _animator = GetComponent<Animator>();
    }
    public void OnPointerEnter(PointerEventData eventData) {
        _animator.SetBool("IsMouseOnTheButton", true);
    }
    public void OnPointerExit(PointerEventData eventData) {
        _animator.SetBool("IsMouseOnTheButton", false);
    }
}
