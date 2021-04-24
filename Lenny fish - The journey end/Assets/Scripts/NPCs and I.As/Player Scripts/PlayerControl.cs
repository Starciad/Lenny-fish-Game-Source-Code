using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [Header("Status")]
    public float speed;
    public float runSpeed;

    [Header("Configs")]
    public Rigidbody2D rb;
    public Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        ViewMouse();
    }

    void FixedUpdate()
    {
        Moviment();
    }

    void Moviment()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(x * speed, y * speed);
        if (Mathf.Abs(x) == 1)
        {
            anim.SetBool("Move", true);
        }
        else
        {
            anim.SetBool("Move", false);
        }

    }

    void ViewMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector3 direction = new Vector3(transform.position.x - mousePosition.x, 1, 1);
        if (direction.x > 0.1)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (direction.x < 0.1)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
