using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private Rigidbody2D rb;
    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //if jump was pressed this frame
        if (InputManager.instance.jumpWasPressed)
        {
            float jumpForce = 5f;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
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
