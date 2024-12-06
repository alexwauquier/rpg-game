using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // InputAction reference
    public InputAction MoveAction;
    // Speed of the player
    public float speed = 5.0f;

    // Animator reference
    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get the InputAction from the PlayerInput component
        MoveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        

        // Update the animation
        UpdateAnimation();
    }

    void UpdateAnimation()
    {
        if (MoveAction.ReadValue<Vector2>().x != 0 || MoveAction.ReadValue<Vector2>().y != 0)
        {
            UpdateMovement();

            animator.SetBool("Walking", true);
            animator.SetFloat("Horizontal", MoveAction.ReadValue<Vector2>().x);
            animator.SetFloat("Vertical", MoveAction.ReadValue<Vector2>().y);
        }
        else
        {
            animator.SetBool("Walking", false);
        }
    }

    void UpdateMovement()
    {
        // Player movement
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
        Vector2 position = (Vector2)transform.position + move * 3.0f * Time.deltaTime;
        transform.position = position;
    }
}
