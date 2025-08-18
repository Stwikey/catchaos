using UnityEngine;
using UnityEngine.InputSystem;
public class InputSys : MonoBehaviour
{
    public static Vector2 Movement;
    private InputAction moveAction;
    private PlayerInput playerInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions["Move"];
    }

    // Update is called once per frame
    private void Update()
    {
        Movement = moveAction.ReadValue<Vector2>();
    }
}
