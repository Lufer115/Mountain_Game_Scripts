// NOTE: This is a portfolio-oriented reconstruction from the compiled Unity WebGL build.
// It is not guaranteed to be byte-for-byte identical to the lost original source.

using UnityEngine;

// CharacterController ladder-climbing controller reconstructed from the build.
public class Climb : MonoBehaviour
{
    public float climbSpeed = 3f;

    private CharacterController characterController;
    private Vector3 moveDirection;
    private bool isOnLadder;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();

        if (characterController == null)
            Debug.LogError("CharacterController not found on player object!");
    }

    private void Update()
    {
        if (!isOnLadder || characterController == null)
            return;

        float vertical = Input.GetAxis("Vertical");
        moveDirection = Vector3.up * vertical * climbSpeed;

        characterController.Move(moveDirection * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ladder"))
        {
            isOnLadder = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ladder"))
        {
            isOnLadder = false;
        }
    }
}
