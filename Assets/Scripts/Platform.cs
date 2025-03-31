using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float Jumpforce = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.relativeVelocity.y <= 0f)
        {


            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = Jumpforce;
                rb.velocity = velocity;

            }

        }

    }
}
