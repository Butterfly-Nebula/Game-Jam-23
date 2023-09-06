using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb2d;
    private Vector2 moveInput;
    private float dirX, dirY;

    public float activeMoveSpeed;
    public float dashSpeed;

    public float dashLength = .5f, dashCooldown = 1f;

    private float dashCounter;
    private float dashCoolCounter;

    public bool canMove;

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
        if (name == "Player1")
        {
            if (canMove)
            {
                dirX = Input.GetAxisRaw("Horizontal") * activeMoveSpeed;
                dirY = Input.GetAxisRaw("Vertical") * activeMoveSpeed;
            }
        }
        if (name == "Player2" && Input.anyKey)
        {
            if (canMove)
            {
                if (Input.GetKey(KeyCode.I))
                {
                    dirY = activeMoveSpeed;
                }
                if (Input.GetKey(KeyCode.K))
                {
                    dirY = -activeMoveSpeed;
                }
                if (Input.GetKey(KeyCode.J))
                {
                    dirX = - activeMoveSpeed;
                }
                if (Input.GetKey(KeyCode.L))
                {
                    dirX = activeMoveSpeed;
                }
            }
        }
        else if (name == "Player2" && !Input.anyKey)
        {
            dirX = 0f;
            dirY = 0f;
        }

        moveInput = new Vector2(dirX, dirY);
        moveInput.Normalize();

        rb2d.velocity = moveInput * activeMoveSpeed;

        if (name == "Player1")
        { 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (dashCoolCounter <= 0 && dashCounter <= 0)
                {
                    canMove = false;
                    destroyTrigger.SetActive(true);
                    activeMoveSpeed = dashSpeed;
                    dashCounter = dashLength;
                    rb2d.velocity = new Vector2(dirX, dirY) * 3;
                }
            }
        }

        if (name == "Player2")
        { 
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                if (dashCoolCounter <= 0 && dashCounter <= 0)
                {
                    canMove = false;
                    destroyTrigger.SetActive(true);
                    activeMoveSpeed = dashSpeed;
                    dashCounter = dashLength;
                    rb2d.velocity = new Vector2(dirX, dirY) * 3;
                }
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
