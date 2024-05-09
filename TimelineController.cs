using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed
    public float rotationSpeed = 2f; // Rotation speed
    public float zoomSpeed = 5f; // Zoom speed

    private void Update()
    {
        // Keyboard input for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Mouse input for rotation
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Zoom input (scroll wheel)
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");

        // Move the camera
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // Rotate the camera
        transform.Rotate(Vector3.up, mouseX * rotationSpeed);
        transform.Rotate(Vector3.right, -mouseY * rotationSpeed);

        // Zoom the camera
        transform.Translate(Vector3.forward * scrollInput * zoomSpeed);

        // Clamp camera position (optional)
        // Add code here to prevent the camera from going too far or too close

        // Example: Clamp camera position within certain bounds
        // transform.position = new Vector3(
        //     Mathf.Clamp(transform.position.x, minX, maxX),
        //     Mathf.Clamp(transform.position.y, minY, maxY),
        //     Mathf.Clamp(transform.position.z, minZ, maxZ)
        // );
    }
}
