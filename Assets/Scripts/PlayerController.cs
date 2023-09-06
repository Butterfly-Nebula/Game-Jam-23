using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb2d;
    private Vector2 moveInput;

    private float activeMoveSpeed;
    public float dashSpeed;

    public float dashLength = .5f, dashCooldown = 1f;

    private float dashCounter;
    private float dashCoolCounter;

    bool canMove;

    public GameObject destroyTrigger;

    // Start is called before the first frame update
    void Start()
    {
        activeMoveSpeed = moveSpeed;

        canMove = true;

        destroyTrigger.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            moveInput.x = Input.GetAxisRaw("Horizontal");
            moveInput.y = Input.GetAxisRaw("Vertical");
        }

        moveInput.Normalize();

        rb2d.velocity = moveInput * activeMoveSpeed;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dashCoolCounter <= 0 && dashCounter <= 0)
            {
                canMove = false;
                destroyTrigger.SetActive(true);
                activeMoveSpeed = dashSpeed;
                dashCounter = dashLength;
            }
        }

        if (dashCounter > 0)
        {
            dashCounter -= Time.deltaTime;

            if (dashCounter <= 0)
            {
                activeMoveSpeed = moveSpeed;
                dashCoolCounter = dashCooldown;
                canMove = true;
                destroyTrigger.SetActive(false);
            }
        }

        if (dashCoolCounter > 0)
        {
            dashCoolCounter -= Time.deltaTime;
        }
    }
}
