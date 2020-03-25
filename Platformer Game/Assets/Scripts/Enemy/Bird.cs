using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    Rigidbody2D myBody;
    Animator anim;

    Vector3 moveDirection = Vector3.left;
    Vector3 originPosition;
    Vector3 movePosition;

    public GameObject birdEgg;
    public LayerMask playerLayer;
    bool attacked;

    bool canMove;

    float speed = 2.5f;


    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        originPosition = transform.position;
        originPosition.x += 6f;

        movePosition = transform.position;
        movePosition.x -= 6f;

        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        MoveTheBird();
    }

    void MoveTheBird()
    {
        if(canMove)
        {
            transform.Translate(moveDirection * speed * Time.smoothDeltaTime);

            if(transform.position.x >= originPosition.x)
            {
                moveDirection = Vector3.left;
                ChangeDirection(0.5f);
            }
            else if (transform.position.x <= movePosition.x)
            {
                moveDirection = Vector3.right;
                ChangeDirection(-0.5f);
            }
        }
    }

    void ChangeDirection (float direction)
    {
        Vector3 tempScale = transform.localScale;
        tempScale.x = direction;
        transform.localScale = tempScale;
    }

}
