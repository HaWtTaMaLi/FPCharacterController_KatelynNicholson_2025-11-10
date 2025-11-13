using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// The video i found for this one was the only one that looked the most organized lol
    /// </summary>

    [Header("Input Action Asset")]
    [SerializeField] private InputAction playerControls;

    [Header("Action Map Name Reference")]
    [SerializeField] private string actionMapName = "Player";

    [Header("Action Name Reference")]
    [SerializeField] private string movement = "Movement";
    [SerializeField] private string rotation = "Rotation";
    [SerializeField] private string jump = "Jump";
    [SerializeField] private string sprint = "Sprint";
    [SerializeField] private string interact = "Interact";

    private InputAction movementAction;
    private InputAction rotationAction;
    private InputAction jumpAction;
    private InputAction sprintAction;
    private InputAction interactAction;

    public Vector2 MovementInput { get; private set; }
    public Vector2 RotationInput { get; private set; }
    public bool JumpTriggered { get; private set; }
    public bool SprintTriggered { get; private set; }
    public bool InteractTriggered { get; private set; }

    [Header("Player Settings")]
    [SerializeField] private float walkSpeed = 1f;
    [SerializeField] private float sprintSpeed = 2f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravityForce = 1f;
    [SerializeField] private float mouseSensitivity = .1f;
    [SerializeField] private float upDownLookRange = 80f; 


    private void Awake()
    {
        InputAction mapReference = playerControls.actionMap.FindAction(actionMapName);

        movementAction = mapReference.actionMap.FindAction(movement);
        rotationAction = mapReference.actionMap.FindAction(rotation);
        jumpAction = mapReference.actionMap.FindAction(jump);
        sprintAction = mapReference.actionMap.FindAction(sprint);
        interactAction = mapReference.actionMap.FindAction(interact);
        ActionToInput();
    }

    private void ActionToInput()
    {
        movementAction.performed += inputInfo => MovementInput = inputInfo.ReadValue<Vector2>();
        movementAction.canceled += inputInfo => MovementInput = Vector2.zero;

        rotationAction.performed += inputInfo => RotationInput = inputInfo.ReadValue<Vector2>();
        rotationAction.canceled += inputInfo => RotationInput = Vector2.zero;

        jumpAction.performed += inputInfo => JumpTriggered = true;
        jumpAction.canceled += inputInfo => JumpTriggered = false;

        sprintAction.performed += inputInfo => SprintTriggered = true;
        sprintAction.canceled += inputInfo => SprintTriggered = false;

        interactAction.performed += inputInfo => InteractTriggered = true;
        interactAction.canceled += inputInfo => InteractTriggered = false;

    }

    private void OnEnable()
    {
        playerControls.actionMap.FindAction(actionMapName).Enable();
    }

    private void OnDisable()
    {
        playerControls.actionMap.FindAction(actionMapName).Disable();
    }
}
