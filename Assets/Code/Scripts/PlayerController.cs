using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // InputAction reference
    public InputAction MoveAction;
    // Speed of the player
    public float speed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get the InputAction from the PlayerInput component
        MoveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // Player movement
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
        Vector2 position = (Vector2)transform.position + move * 3.0f * Time.deltaTime;
        transform.position = position;
    }
}
