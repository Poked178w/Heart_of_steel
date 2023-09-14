using UnityEngine;

public class JumpController : MonoBehaviour
{
    public float jumpForce = 5f;
    public float gravity = -9.81f;
    public float groundCheckDistance = 0.2f;
    public Transform groundCheckTransform;

    private CharacterController characterController;
    private bool isJumping = false;
    private Vector3 velocity;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // Check if the character is on the ground
        bool isGrounded = CheckGrounded();

        // If the character is on the ground and not already jumping, allow jumping
        if (isGrounded && !isJumping)
        {
            // Check for jump input (e.g., Space key)
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Apply jump force
                velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
                isJumping = true;
            }
        }

        // Apply gravity
        velocity.y += gravity * Time.deltaTime;

        // Move the character
        characterController.Move(velocity * Time.deltaTime);

        // Reset jumping state if the character is back on the ground
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
            isJumping = false;
        }
    }

    private bool CheckGrounded()
    {
        // Perform a sphere cast to check if the character is on the ground
        return Physics.CheckSphere(groundCheckTransform.position, groundCheckDistance, LayerMask.GetMask("Ground"));
    }
}