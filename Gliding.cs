

using UnityEngine;

// CharacterController-based gliding
public class Gliding : MonoBehaviour
{
    public float fallSpeed = 2f;

    private CharacterController controller;
    private Vector3 velocity;

    public bool isGliding;

    public float gravity = -9.81f;
    public float glideGravity = -2f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (controller == null)
            return;

        if (Input.GetKey(KeyCode.Space))
            isGliding = true;
        else
            isGliding = false;

        float currentGravity = isGliding ? glideGravity : gravity;

        if (controller.isGrounded && velocity.y < 0f)
            velocity.y = -2f;

        velocity.y += currentGravity * Time.deltaTime;

        if (velocity.y < -fallSpeed && isGliding)
            velocity.y = -fallSpeed;

        controller.Move(velocity * Time.deltaTime);
    }
}
