using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 6f;

    public float jumpSpeed = 12f;

    public float dashSpeed;
    public float dashCooldown = 3;
    public float dashCooldownRemaining;
    public float dashtime;
    public float startdashtime;

    private int lookDirection;

    public int JumpCounter = 2;

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        //Våran variabel kopplas till rätt rigidbody
        rbody = GetComponent<Rigidbody2D>();
        dashtime = startdashtime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        JumpCounter = 2;
    }

    // Update is called once per frame
    void Update()
    {
        //När en av horizontala rörelse knapparna trycks in så går Player i den riktningen med Playerns moveSpeed
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);
        if (Input.GetKeyDown(KeyCode.A))
        {
            lookDirection = 1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            lookDirection = 2;
        }
        //Om hopp knappen trycks in så händer något
        if (Input.GetButtonDown("Jump") && JumpCounter > 0)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
            JumpCounter = JumpCounter - 1;
        }
        if (Input.GetKey(KeyCode.LeftShift) && dashtime > 0 && dashCooldownRemaining <= 0)
        {
            if (lookDirection == 1)
            {
                rbody.velocity = new Vector2(-dashSpeed, rbody.velocity.y);
                dashtime -= Time.deltaTime;
            }
            else
            {
                rbody.velocity = new Vector2(dashSpeed, rbody.velocity.y);
                dashtime -= Time.deltaTime;
            }
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) && dashCooldownRemaining <= 0)
            {
                dashtime = startdashtime;
                dashCooldownRemaining = dashCooldown;
            }
        dashCooldownRemaining = dashCooldownRemaining - (1 * Time.deltaTime);
    }
}
