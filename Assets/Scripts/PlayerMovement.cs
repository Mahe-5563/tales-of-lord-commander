using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{

    private float player;
    public float playerSpeed = 3f;
    public float playerJumpHeight = 5;
    private Rigidbody2D PlayerRigidbody;
    public LayerMask JumpLayer; 
    //public Transform groundCheck;
    bool isGrounded = true;
    public Collider2D playerCollider;
    bool facingRight = true;


    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody2D>();
             
    }


    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
            facingRight = false;

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
                
            if (!playerCollider.IsTouchingLayers(JumpLayer))
            {             
                return;              
            }

             PlayerRigidbody.velocity = new Vector2(PlayerRigidbody.velocity.x, playerJumpHeight);
            //PlayerRigidbody.AddForce(new Vector2(0f, playerJumpHeight));
        }
    }

   

}
