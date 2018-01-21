using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rigidBody2D;

    /// <summary>
    /// Find components of the player.
    /// </summary>
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Updates every frame.
    /// </summary>
    void Update()
    {
        UpdateMovement();
    }

    /// <summary>
    /// Checks the if movement keys are pressed.  If they are, start the respective walking animation and update the velocity of the RigidBody2D.
    /// If not, set the idle animation per the last movement direction and set the velocity of the RigidBody2D to zero to stop movement.
    /// </summary>
    void UpdateMovement()
    {
        int currentDirection = animator.GetInteger("direction");
        bool moving = animator.GetBool("moving");
        Vector2 movementDirection = Vector2.zero;

        if (Input.GetKey(KeyCode.A))
        {
            if (currentDirection != 0 || !moving)
            {
                animator.SetInteger("direction", 0);
                animator.SetBool("moving", true);
            }
            movementDirection = UpdateVerticalMovement(movementDirection);

            movementDirection.x = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (currentDirection != 2 || !moving)
            {
                animator.SetInteger("direction", 2);
                animator.SetBool("moving", true);
            }
            movementDirection = UpdateVerticalMovement(movementDirection);

            movementDirection.x = 1;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            if (currentDirection != 1 || !moving)
            {
                animator.SetInteger("direction", 1);
                animator.SetBool("moving", true);
            }

            movementDirection.y = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (currentDirection != 3 || !moving)
            {
                animator.SetInteger("direction", 3);
                animator.SetBool("moving", true);
            }

            movementDirection.y = -1;
        }
        else //No movement, set idle
        {
            animator.SetBool("moving", false);
        }

        rigidBody2D.velocity = movementDirection;
    }

    /// <summary>
    /// Checks to see if the vertical keys are pressed and updates the passed vector without changing the animation.
    /// We need this because we don't want to set 2 animations when a horizontal movement key and a vertical movement key is pushed.
    /// </summary>
    /// <param name="velocity">A Vector to contain the player's movement.</param>
    /// <returns>An updated vector with the new vertical movement added.</returns>
    Vector2 UpdateVerticalMovement(Vector2 velocity)
    {
        if (Input.GetKey(KeyCode.W))
        {
            velocity.y = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            velocity.y = -1;
        }
        return velocity;
    }
}
