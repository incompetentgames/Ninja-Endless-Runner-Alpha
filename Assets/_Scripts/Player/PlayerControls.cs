using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //if jump was pressed this frame
        if (InputManager.instance.jumpWasPressed)
        {
           Debug.Log("Jump Was Pressed");
        }

        //if jump is being held
        if (InputManager.instance.jumpIsHeld)
        {
            Debug.Log("Jump is being held");

        }

        //if jump has been released
        if (InputManager.instance.jumpWasReleased) {
            Debug.Log("Jump Was Released");
        }
    }
}
