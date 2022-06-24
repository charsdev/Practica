using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float Speed;
    public float rotationSpeed = 100f;
    public Animator animator;
    private Vector3 velocity;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rigidbody2D.velocity *= 0.95f;

        var movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        movement.Normalize();

        transform.Rotate(Vector3.forward * -movement.x, rotationSpeed * Time.deltaTime);

        rigidbody2D.position += (Vector2)(movement.y * transform.up) * Speed * Time.deltaTime;

        //velocity += (movement.y * (transform.up * 5)) * Time.deltaTime;

        //// apply friction if np input.
        //if (movement.y == 0.0f)
        //{
        //    velocity *= 0.95f;
        //}

        //var clampedVelocity = Vector3.ClampMagnitude(velocity, 1);
        //transform.Translate(clampedVelocity * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.Space) )
        {
            rigidbody2D.AddForce(transform.up * 10f, ForceMode2D.Impulse);
            animator?.SetTrigger("Swim");
        }
    }
}
