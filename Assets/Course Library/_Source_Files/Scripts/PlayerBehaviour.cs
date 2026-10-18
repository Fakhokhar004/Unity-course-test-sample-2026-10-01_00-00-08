using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    // Player speed and turn speed variables (exposed in the Unity Inspector)
    public float Playerspeed = 0.5f;
    public float turnSpeed = 1f;

    // InputAction for player movement (exposed in the Unity Inspector)
    public InputAction moveAction;

    // Variable to store the player's movement input
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Enable the moveAction to start receiving input
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // Read the player's movement input from the moveAction ( x for horizontal, y for vertical)
        moveInput = moveAction.ReadValue<Vector2>();

        // Move the player forward/backward based on the vertical input (moveInput.y)
        transform.Translate(Vector3.forward * Time.deltaTime * Playerspeed * moveInput.y );

        // Rotate the player left/right based on the horizontal input (moveInput.x)
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * moveInput.x);

    }
}
