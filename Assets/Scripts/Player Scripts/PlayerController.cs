using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rigidBody2D;

    void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        UpdateMovement();
    }

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
