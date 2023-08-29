using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KlavyeHareket : MonoBehaviour
{

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isRunning", true);
            transform.Translate(new Vector3(0, 0, 2f) * Time.deltaTime);
        }

        else
        {
            animator.SetBool("isRunning", false);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isJumping", true);
        }

        else
        {
            animator.SetBool("isJumping", false);
        }
    }
}
