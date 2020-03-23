using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float speed = 5f;

    Rigidbody2D myBody;
    Animator anim;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        PlayerWalk();
    }

    void PlayerWalk()
    {
        float h = Input.GetAxisRaw("Horizontal");

        if(h > 0)
        {
            myBody.velocity = new Vector2(speed, myBody.velocity.y);

            ChangeDirection(1);
        }
        else if(h < 0)
        {
            myBody.velocity = new Vector2(-speed, myBody.velocity.y);

            ChangeDirection(-1);
        }
        else
        {
            myBody.velocity = new Vector2(0f, myBody.velocity.y);
        }

        anim.SetInteger("Speed", Mathf.Abs((int)myBody.velocity.x));

    }

    void ChangeDirection(int direction)
    {
        Vector3 tempScale = transform.localScale;
        tempScale.x = direction;
        transform.localScale = tempScale;
    }

}
