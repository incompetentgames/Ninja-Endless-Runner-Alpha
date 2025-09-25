using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;

    [HideInInspector] public InputSystem_Actions controls;
    [HideInInspector] public bool jumpWasPressed, jumpIsHeld, jumpWasReleased;

    void Awake()
    {
        //set this as a singleton
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        //initalize Input Actions
        controls = new InputSystem_Actions();         
    }

    void OnEnable()
    {
        controls.Enable();
    }

    void Update()
    {
        //if jump was pressed this frame
        jumpWasPressed = controls.Player.Jump.WasPressedThisFrame();
        //if jump is being held
        jumpIsHeld = controls.Player.Jump.IsPressed();
        //if jump has been released
        jumpWasReleased = controls.Player.Jump.WasReleasedThisFrame();
    }

    void OnDisable()
    {
        controls.Disable();
    }    
}
