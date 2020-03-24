using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snail : MonoBehaviour
{
    public float moveSpeed = 1f;
    Rigidbody2D myBody;
    Animator anim;

    bool moveLeft;

    public Transform down_Collision;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        moveLeft = true;
    }

    
    void Update()
    {
        if(moveLeft)
        {
            myBody.velocity = new Vector2(-moveSpeed, myBody.velocity.y);
        }
        else  
        {
            myBody.velocity = new Vector2(moveSpeed, myBody.velocity.y);
        }

        CheckCollision();
    }

    void CheckCollision()
    {
        if (!Physics2D.Raycast(down_Collision.position, Vector2.down, 0.1f))
        {
            ChangeDirection();
        }
    }

    void ChangeDirection()
    {
        moveLeft = !moveLeft;

        Vector3 tempScale = transform.localScale;
        
        if (moveLeft)
        {
            tempScale.x = Mathf.Abs(tempScale.x);
        }
        else
        {
            tempScale.x = -Mathf.Abs(tempScale.x);
        }
        transform.localScale = tempScale;
    }
}
