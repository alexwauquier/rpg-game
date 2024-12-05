using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0.0f;
        float vertical = 0.0f;
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            horizontal = -1.0f;
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            horizontal = 1.0f;
        }
        else
        {
            horizontal = 0.0f;
        }
        // Vertical movement
        if (Keyboard.current.downArrowKey.isPressed)
        {
            vertical = -1.0f;
        }
        else if (Keyboard.current.upArrowKey.isPressed)
        {
            vertical = 1.0f;
        }
        else
        {
            vertical = 0.0f;
        }
        // Debug.Log(horizontal);
        Debug.Log(horizontal);
        // Debug.Log(vertical);
        Debug.Log(vertical);


        Vector2 position = transform.position;
        position.x = position.x + horizontal * speed;
        transform.position = position;
        position.y = position.y + vertical * speed;
        transform.position = position;
    }
}
