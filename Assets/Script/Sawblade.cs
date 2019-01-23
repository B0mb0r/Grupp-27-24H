using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sawblade : MonoBehaviour
{
    public float movespeed;
    private Rigidbody2D rbody;
    public bool left = true;


    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (left == true)
        {
            rbody.velocity = -(Vector2)transform.right * movespeed;
        }
        else
        {
            rbody.velocity = (Vector2)transform.right * movespeed;
        }
    }
}
