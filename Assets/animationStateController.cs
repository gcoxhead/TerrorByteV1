using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
            {
                animator.SetBool("isRunning", true);
            }
        if (!Input.GetKey("up"))
            {
                animator.SetBool("isRunning", false);
            }

         if (Input.GetKey("down"))
            {
                animator.SetBool("isBackwards", true);
            }
        if (!Input.GetKey("down"))
            {
                animator.SetBool("isBackwards", false);
            }

        if (Input.GetKey("space"))
            {
                animator.SetBool("isJumping", true);
            } 

         if (!Input.GetKey("space"))
            {
                animator.SetBool("isJumping", true);
            }   
    }
}

