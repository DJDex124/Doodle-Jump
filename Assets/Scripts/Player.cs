using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float movementSpeed = 10f;
    float Movement = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Movement = Input.GetAxis("Horizontal")* movementSpeed;    // movement code below

    }


    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = Movement;
        rb.velocity = velocity;
    }




}
