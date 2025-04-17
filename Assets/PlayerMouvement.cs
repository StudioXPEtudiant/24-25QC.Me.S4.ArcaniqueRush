using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{
    float hInput;
    float movespeed = 5f;
    bool IsFacingRight = false;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");

        FlipSprite();
    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(hInput * movespeed, rb.velocity.y);
    }


    void FlipSprite()
    {
        if(IsFacingRight && hInput < 0f || !IsFacingRight && hInput > 0f)
        {
            IsFacingRight = !IsFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }
}
