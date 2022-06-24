using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAI : MonoBehaviour
{
    public Transform target;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float rotateSpeed = 200f;
    
    private Rigidbody2D rigidbody2D;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (Vector2)target.transform.position - rigidbody2D.position;
        direction.Normalize();

        float rotation = Vector3.Cross(direction, transform.up).z;

        rigidbody2D.angularVelocity = -rotation * rotateSpeed;
        rigidbody2D.velocity = transform.up * speed;
    }
}
