using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_two : MonoBehaviour {

    public SpriteRenderer sprite;
    public PlatformEffector2D ground;
    public Rigidbody2D body;
    public GameObject normalSpit, feet, superSpit, bullet;

    public int stomach1 = 0, stomach2 = 0;

    public float velocityY, digestTime;
    private float moveSpeed, jumpForce, holdJump = 0, diveForce, bulletSpeed, spitCooldown, spitTimer, jumpCount, baseSpeed = 3f, boostSpeed = 5f, barkDistance, barkHeight, scaleX, moveVector;

    private bool bat, shoe, rabbit, squirrel, isFull, jump2, walking, grounded, upsideDown, canSpit, timerOn;

    void Start()
    {
        ground = GameObject.FindGameObjectWithTag("Player2Ground").GetComponent<PlatformEffector2D>();
        sprite = GetComponent<SpriteRenderer>();
        timerOn = false;
        spitCooldown = 1f;
        bulletSpeed = 10f;
        moveSpeed = 3f;
        jumpForce = 5f;
        diveForce = 3f;
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        velocityY = body.velocity.y;
        if (body.velocity.y == 0.1962f || body.velocity.y == -0.1962f)
            body.velocity = new Vector2(body.velocity.x, 0);
        if (body.velocity.y > 5f)
        {
            body.velocity = new Vector2(body.velocity.x, 5f);
        }
        else if (body.velocity.y < -5f)
        {
            body.velocity = new Vector2(body.velocity.x, -5f);
        }
        flip();
        detectGround();
        howlBeam();
        spitBoost();
        spit();
        skills();

        if (upsideDown)
        {
            eat();
        }
        if (!upsideDown)
        {
            spit();
        }
        bark();

        Vector3 scale = transform.localScale;
        if (transform.position.y > ground.transform.position.y)
        {
            body.gravityScale = 1f;
            scale.y = 1f;
        }
        else if (transform.position.y < ground.transform.position.y)
        {
            body.gravityScale = -1f;
            scale.y = -1f;
        }
        transform.localScale = scale;

        if (transform.localScale.x > 0)
        {
            scaleX = 1f;
        }
        else
            scaleX = -1f;
    }

    void FixedUpdate()
    {
        movement();
        doubleJump();
        speedBoost();
        jump();
    }

    void movement()
    { 
        if (Input.GetKey(KeyCode.J))
            moveVector = -1f;
        if (Input.GetKey(KeyCode.L))
            moveVector = 1f;
        //WALK
        if (Input.GetKey(KeyCode.J) || Input.GetKey(KeyCode.L))
        {
            body.velocity = new Vector2(moveVector * moveSpeed, body.velocity.y);
            walking = true;
        }
        else
        {
            walking = false;
        }
        if (!Input.GetKey(KeyCode.J) && !Input.GetKey(KeyCode.L))
        {
            moveVector = 0;
        }
    }


    void flip()
    {
        Vector3 scale = transform.localScale;
        if (moveVector < 0)
        {
            scale.x = -1f;
        }
        else if (moveVector > 0)
        {
            scale.x = 1f;
        }
        transform.localScale = scale;
    }

    void jump()
    {
        if (!upsideDown)
        {

            if (Input.GetKeyDown(KeyCode.I) && grounded)
            {
                body.velocity = new Vector2(body.velocity.x, 0);
                body.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            }
            if (Input.GetKey(KeyCode.K) && grounded)
            {
                body.velocity = new Vector2(body.velocity.x, 0);
                body.AddForce(new Vector2(0, -jumpForce), ForceMode2D.Impulse);
                upsideDown = true;
                ground.rotationalOffset = 180f;
            }
        }
        else if (upsideDown)
        {

            if (Input.GetKeyDown(KeyCode.K) && grounded)
            {
                body.velocity = new Vector2(body.velocity.x, 0);
                body.AddForce(new Vector2(0, -jumpForce), ForceMode2D.Impulse);
            }
            if (Input.GetKey(KeyCode.I) && grounded)
            {
                body.velocity = new Vector2(body.velocity.x, 0);
                body.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                upsideDown = false;
                ground.rotationalOffset = 0f;
            }
        }
    }

    void doubleJump()
    {
        if (bat)
        {
            if (!grounded)
            {
                if (!upsideDown)
                {

                    if (Input.GetKeyDown(KeyCode.I) && !jump2)
                    {
                        body.velocity = new Vector2(body.velocity.x, 0);
                        body.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                        jump2 = true;
                    }
                }
                else if (upsideDown)
                {

                    if (Input.GetKeyDown(KeyCode.K) && !jump2)
                    {
                        body.velocity = new Vector2(body.velocity.x, 0);
                        body.AddForce(new Vector2(0, -jumpForce), ForceMode2D.Impulse);
                        jump2 = true;
                    }
                }
            }
        }
        if (grounded)
        {
            jump2 = false;
        }
    }

    void speedBoost()
    {
        if (rabbit)
            moveSpeed = boostSpeed;
        else
            moveSpeed = baseSpeed;
    }

    void howlBeam()
    {
        if (squirrel)
        {
            barkDistance = transform.localScale.x * 4f;
            barkHeight = transform.localScale.y * 1f;
        }
        else
        {
            barkDistance = transform.localScale.x * 2f;
            barkHeight = transform.localScale.y * 2f;
        }
    }

    void spitBoost()
    {
        if (shoe)
        {
            bullet = superSpit;
        }
        else
            bullet = normalSpit;
    }

    void eat()
    {
        if (stomach1 == 0 || stomach2 == 0)
            isFull = false;
        RaycastHit2D hit;
        if (!isFull)
        {
            if (Input.GetKey(KeyCode.U))
            {
                Debug.DrawLine(transform.position, new Vector2(transform.position.x + transform.localScale.x, transform.position.y), Color.green);
                hit = Physics2D.Linecast(transform.position, new Vector2(transform.position.x + transform.localScale.x, transform.position.y), 1 << LayerMask.NameToLayer("Edible"));
                if (hit.transform != null)
                {
                    Debug.Log("hit :" + hit.transform.gameObject.name);
                    if (hit.transform.gameObject.GetComponent<Edible>() != null)
                    {
                        hit.transform.gameObject.GetComponent<Edible>().edibleAction();
                    }
                }
            }
        }
    }

    void bark()
    {
        RaycastHit2D hit;
        if (Input.GetKey(KeyCode.O))
        {
            Debug.DrawLine(transform.position, new Vector2(transform.position.x + barkDistance * scaleX, transform.position.y), Color.green);
            hit = Physics2D.CircleCast(transform.position, barkHeight, transform.right, barkDistance, 1 << LayerMask.NameToLayer("Enemy"));
            if (hit.collider != null)
            {
                if (hit.collider.tag == "Enemy")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }

    void digest()
    {
        if (stomach1 != 0)
        {
            stomach1 = stomach2;
            stomach2 = 0;
        }
    }

    void spit()
    {
        if (stomach1 != 0)
        {
            if (Input.GetKey(KeyCode.P) && canSpit)
            {
                Vector2 myPos = new Vector2(transform.position.x + transform.localScale.x / 2, transform.position.y);
                GameObject projectile = (GameObject)Instantiate(bullet, myPos, Quaternion.Euler(0, 0, 90 * scaleX));
                projectile.GetComponent<Rigidbody2D>().velocity = new Vector2(scaleX, 0) * bulletSpeed;
                spitTimer = Time.time + spitCooldown;
                canSpit = false;
                digest();
            }
            if (spitTimer < Time.time)
            {
                canSpit = true;
            }
        }
    }

    void detectGround()
    {
        RaycastHit2D hit;
        Debug.DrawLine(transform.position, new Vector2(transform.position.x, feet.transform.position.y), Color.green);
        hit = Physics2D.Linecast(transform.position, new Vector2(transform.position.x, feet.transform.position.y), 1 << LayerMask.NameToLayer("Player2Ground"));
        if (hit.collider != null)
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }

    void skills()
    {
        if (stomach1 == 1 || stomach2 == 1)
        {
            shoe = true;
        }
        else
            shoe = false;

        if (stomach1 == 2 || stomach2 == 2)
        {
            rabbit = true;
        }
        else
            rabbit = false;

        if (stomach1 == 3 || stomach2 == 3)
        {
            squirrel = true;
        }
        else
            squirrel = false;

        if (stomach1 == 4 || stomach2 == 4)
        {
            bat = true;
        }
        else
            bat = false;
    }

    public void setIsShoe(int x)
    {
        if (stomach1 == 0)
            stomach1 = x;
        else
            stomach2 = x;

        if (stomach1 != 0 && stomach2 != 0)
        {
            isFull = true;
        }
    }

    public void setIsRabbit(int x)
    {
        if (stomach1 == 0)
            stomach1 = x;
        else
            stomach2 = x;
        if (stomach1 != 0 && stomach2 != 0)
        {
            isFull = true;
        }
    }

    public void setIsSquirrel(int x)
    {
        if (stomach1 == 0)
            stomach1 = x;
        else
            stomach2 = x;
        if (stomach1 != 0 && stomach2 != 0)
        {
            isFull = true;
        }
    }

    public void setIsBat(int x)
    {
        if (stomach1 == 0)
            stomach1 = x;
        else
            stomach2 = x;
        if (stomach1 != 0 && stomach2 != 0)
        {
            isFull = true;
        }
    }
}

