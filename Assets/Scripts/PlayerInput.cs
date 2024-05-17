using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;


public class PlayerInput : MonoBehaviour
{
    [Header("Movement Settings")]
    public readonly bool _analogMovement = false;
    public bool _canJump;
    private bool _isDeviceMouse;
    public Vector2 _look;
    public static PlayerInput Instance { get; private set; }


    public event EventHandler OnSprintAction;
    public event EventHandler OnInteractAction;
    public event EventHandler OnFightModeAction;

    public event EventHandler OnJumpAction;
    public event EventHandler OnPauseAction;

    public event UnityAction EnableDefenseEvent = delegate { };
    public event UnityAction DisableDefenseEvent = delegate { };

    public PlayerInputActions _playerInputActions;
    public event UnityAction<Vector2, bool> CameraMoveEvent = delegate { };
    public event UnityAction EnableMouseControlCameraEvent = delegate { };
    public event UnityAction DisableMouseControlCameraEvent = delegate { };

    public bool IsCurrentDeviceMouse
    {
        get
        {
#if ENABLE_INPUT_SYSTEM
            return _isDeviceMouse;
#else
				return false;
#endif
        }
    }



    private void Awake()
    {
        Instance = this;
        _playerInputActions = new PlayerInputActions();
        _playerInputActions.Player.Enable();


        _playerInputActions.Player.Sprint.performed += OnSprint_performed;
        _playerInputActions.Player.Interact.performed += OnInteract_performed;
        _playerInputActions.Player.FightMode.performed += OnFightMode_performed;
        
        _playerInputActions.Player.Jump.performed += OnJump_performed;
        _playerInputActions.Player.Pause.performed += OnPause_performed;

    }

    
    private void OnSprint_performed(InputAction.CallbackContext context)
    {
        OnSprintAction?.Invoke(this, EventArgs.Empty);
    }
    private void OnInteract_performed(InputAction.CallbackContext context)
    {
        OnInteractAction?.Invoke(this, EventArgs.Empty);
    }

    public bool IsSprinting()
    {
        return _playerInputActions.Player.Sprint.IsPressed();
    }
    public bool IsJumping()
    {
        _canJump = _playerInputActions.Player.Jump.IsPressed();
        return _canJump;
    }
    public Vector2 GetMovementVector()
    {
        Vector2 inputVector = _playerInputActions.Player.Move.ReadValue<Vector2>();
        return inputVector;
    }

    private void OnFightMode_performed(InputAction.CallbackContext obj)
    {
        OnFightModeAction?.Invoke(this, EventArgs.Empty);

    }


    private void OnDefense_performed(InputAction.CallbackContext obj)
    {
        EnableDefenseEvent.Invoke();
    }
    private void OnDefense_canceled(InputAction.CallbackContext obj)
    {
        DisableDefenseEvent?.Invoke();
    }

    private void OnRotateCamera(InputAction.CallbackContext context)
    {
        CameraMoveEvent?.Invoke(context.ReadValue<Vector2>(), IsDeviceMouse(context));
        _isDeviceMouse = IsDeviceMouse(context);
        _look = context.ReadValue<Vector2>();
    }
    private void OnJump_performed(InputAction.CallbackContext obj)
    {
        OnJumpAction?.Invoke(this, EventArgs.Empty);
    }
 
    private void OnPause_performed(InputAction.CallbackContext context)
    {

        OnPauseAction?.Invoke(this, EventArgs.Empty);
    }

    private bool IsDeviceMouse(InputAction.CallbackContext context) => context.control.device.name == "Mouse";

    public void OnMouseControlCamera(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            EnableMouseControlCameraEvent.Invoke();

        if (context.phase == InputActionPhase.Canceled)
            DisableMouseControlCameraEvent.Invoke();
    }


    private void OnEnable()
    {
        _playerInputActions.Player.Enable();
    }

    private void OnDisable()
    {
        _playerInputActions.Player.Disable();
        UnSubscribeEvents();
    }



    private void UnSubscribeEvents()
    {
        _playerInputActions.Player.Sprint.performed -= OnSprint_performed;
        _playerInputActions.Player.Interact.performed -= OnInteract_performed;
        _playerInputActions.Player.FightMode.performed -= OnFightMode_performed;
        _playerInputActions.Player.Jump.performed -= OnJump_performed;
        _playerInputActions.Player.Pause.performed -= OnPause_performed;
    }
}
