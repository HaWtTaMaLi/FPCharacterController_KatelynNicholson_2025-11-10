using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Controls")]
    public int speed = 5;
    public int jumpHight = 1;
    public float gravity = -9.8f;

    public CharacterController controller;
    public Vector2 moveInput;
    public Vector3 velocity;

    public bool isGrounded = true;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    public void OnMove(InputAction.CallbackContext input)
    {
        moveInput = input.ReadValue<Vector2>();
    }

    public void OnJump()
    {
        //somewhere in here isGroundedm = false
        //isGrounded = false;
    }

    void Update()
    {
        
    }
}
