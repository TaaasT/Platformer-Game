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
        }
        else if(h < 0)
        {
            myBody.velocity = new Vector2(-speed, myBody.velocity.y);
        }
    }
}
