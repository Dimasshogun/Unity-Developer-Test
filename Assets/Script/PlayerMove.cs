using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //component
    private CharacterController characterController;
    private Animator animator;

    //var move
    private float inputX;
    private float inputZ;
    private Vector3 movement;
    private Vector3 velocity;
    private float moveSpeed;
    private float gravity;

    // Start is called before the first frame update
    void Start()
    {
        //component
        GameObject tempPlayer = GameObject.FindGameObjectWithTag("Player");
        characterController = tempPlayer.GetComponent<CharacterController>();
        animator = tempPlayer.transform.GetChild(0).GetComponent<Animator>();

        //etc
        moveSpeed = 4f;
        gravity = 0.5f;

    }

    // Update is called once per frame
    void Update()
    {
        //inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");

        ////when moving forward
        //if (inputZ == 0)
        //{
        //    animator.SetBool("run_multi", false);
        //}
        //else
        //{
        //    animator.SetBool("run_multi", true);
        //}
    }
    private void FixedUpdate()
    {
        //grafity
        if (characterController.isGrounded)
        {
            velocity.y = 0f;
        }
        else
        {
            velocity.y -= gravity * Time.deltaTime;
        }

        //input forward
        movement = characterController.transform.forward * inputZ;

        //charakter rotate
        characterController.transform.Rotate(Vector3.up * inputX * (100f * Time.deltaTime));
        
        //charakter move
        characterController.Move(movement * moveSpeed * Time.deltaTime);
        characterController.Move(velocity);
    }
}
