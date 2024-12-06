using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Player and offset variables
    public GameObject player;
    private Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Declare the offset variable
        offset = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Set camera position
        transform.position = player.transform.position + offset;
    }
}
