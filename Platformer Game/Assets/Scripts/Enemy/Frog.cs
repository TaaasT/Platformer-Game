using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    private Animator anim;

    private bool animation_Started;
    private bool animation_Finished;

    private int jumpedTimes;
    private bool jumpLeft = true;

    private string corutine_Name = "FrogJump";

    private void Awake()
    {
        anim = GetComponent<Animator>();    
    }

    void Start()
    {
        StartCoroutine(corutine_Name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FrogJump()
    {
        yield return new WaitForSeconds(Random.Range(1f, 4f));

        if(jumpLeft)
        {
            anim.Play("FrogJumpLeft");
        }
        else
        {

        }

        StartCoroutine(corutine_Name);
    }

    void AnimationFinished()
    {
        anim.Play("FrogIdleLeft");
    }
}
