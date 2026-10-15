// NOTE: This is a portfolio-oriented reconstruction from the compiled Unity WebGL build.
// It is not guaranteed to be byte-for-byte identical to the lost original source.

using UnityEngine;

// Reconstructed from the final build.
public class CameraController : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity = 100f;
    public float maxVerticalAngle = 80f;

    private float verticalRotation;

    private void Update()
    {
        RotateCamera();
    }

    private void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(
            verticalRotation,
            -maxVerticalAngle,
            maxVerticalAngle
        );

        transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

        if (player != null)
            player.Rotate(Vector3.up * mouseX);
    }
}
