using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20.0f;

    public float turnSpeed = 45.0f;

    private float horizontalInput;

    private float fowardInput;

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");

        if(horizontalInput > 0 || horizontalInput < 0 || fowardInput > 0 || fowardInput < 0)
        {
            animator.SetBool("walk", true);
        }
        else
        {
            animator.SetBool("walk", false);
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
       {
        // Attack with sword
        animator.SetTrigger("Attack");
       }

    }

    
    
}
