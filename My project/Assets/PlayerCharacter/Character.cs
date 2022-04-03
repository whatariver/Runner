using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Character : MonoBehaviour
{
    CharacterController characterController;
    public float x, z;
    public int r;
    public float jumpSpeed = 1.6f;
    public float speed = 6.0f;
    public float gravity = 9.81f;
    public Vector3 move = Vector3.zero;



    void Start()
    {
        characterController = this.GetComponent<CharacterController>();

    }

    void Update()
    {
        
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        if (characterController.isGrounded)
        {

         move = transform.right * x + transform.forward * z;
            
            if (Input.GetButton("Jump"))
            {
                move.y = jumpSpeed;

            }
        }        

        move.y -= gravity * Time.deltaTime;

        characterController.Move(move * speed * Time.deltaTime);

        if(r==1)
        {
            characterController.Move(transform.right * -6 * Time.deltaTime + move/10);
        }
        if(r==-1)
        {
            characterController.Move(transform.right * 6 * Time.deltaTime + move / 10);
        }
        
        if(transform.position.y < -10)
        {
            SceneManager.LoadScene(0);
        }

    }
}

