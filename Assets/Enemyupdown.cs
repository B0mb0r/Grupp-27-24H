using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyupdown : MonoBehaviour
{
    public float speed = 1f;
    public float upspeed = 1f;
    public bool Down = true;
    private Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (Down == true)
        {
            rbody.velocity = -(Vector2)transform.up * speed;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.velocity = (Vector2)transform.up * upspeed;
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Inviseblewall")
        {
            Down = !Down;
        }
    }
}
