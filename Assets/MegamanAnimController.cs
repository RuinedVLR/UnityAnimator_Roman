using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class MegamanAnimController : MonoBehaviour
{
    public Animator animController;
    public Vector2 moveInput;

    int moveXHash = Animator.StringToHash("MoveInputX");

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animController = GetComponent<Animator>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();

        animController.SetInteger("MoveInputX", (int)moveInput.x);
    }
}
