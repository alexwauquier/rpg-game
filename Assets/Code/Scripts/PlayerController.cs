using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 velocity;

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
        velocity = Vector2.zero;
        velocity.x = MoveAction.ReadValue<Vector2>().x;
        velocity.y = MoveAction.ReadValue<Vector2>().y;

        // Update the animation
        UpdateAnimation();
    }

    void UpdateAnimation()
    {
        if (velocity != Vector2.zero)
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
        rb.MovePosition(rb.position + velocity * speed * Time.fixedDeltaTime);
    }


}

