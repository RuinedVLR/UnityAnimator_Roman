using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class CubeSpinnerAnimController : MonoBehaviour
{
    public Animator animController;

    // Store animator bool parameter as a hash int for better perfomance
    private int isRotatingHash = Animator.StringToHash("IsRotating");

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animController = GetComponent<Animator>();
    }

    public void ToggleSpin(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            animController.SetBool(isRotatingHash, !animController.GetBool(isRotatingHash));
        }
    }
}
