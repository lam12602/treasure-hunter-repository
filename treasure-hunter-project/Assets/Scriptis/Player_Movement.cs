using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //public variables
    public float movementForce = 10f;
    public float jumpForce = 1000f;
    public Collider2D jumpSensor;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Condition: When the player presses a button
        if (Input.GetKey(KeyCode.D))
        {
            //Action: Apply a force (move the player)
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

            //Add a force to the rigid body to move the player
            ourRigidbody.AddForce(Vector2.right * movementForce);
            float currentspeedH = ourRigidbody.velocity.x;
            float currentspeedV = ourRigidbody.velocity.y;

            //get the animator component used for setting animation
            Animator ourAnimator = GetComponent<Animator>();

            //tell animator what speeds are

            ourAnimator.SetFloat("speed_walk", currentspeedH);
            ourAnimator.SetFloat("player_V", currentspeedV);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //Action: Apply a force (move the player)
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

            //Add a force to the rigid body to move the player
            ourRigidbody.AddForce(Vector2.left * movementForce);

            float currentspeedH = ourRigidbody.velocity.x;
            float currentspeedV = ourRigidbody.velocity.y;

            //get the animator component used for setting animation
            Animator ourAnimator = GetComponent<Animator>();

            //tell animator what speeds are

            ourAnimator.SetFloat("speed_walk", currentspeedH);
            ourAnimator.SetFloat("player_V", currentspeedV);
        }

        //condition: when the player first presses space
        bool isTuchingGround = jumpSensor.IsTouchingLayers(LayerMask.GetMask("Ground"));
        if (Input.GetKeyDown(KeyCode.Space)&& isTuchingGround)
        {
            //Action applay a force(push player up)
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

            //Add a force to the rigid body to move the player
            ourRigidbody.AddForce(Vector2.up * jumpForce);

            float currentspeedH = ourRigidbody.velocity.x;
            float currentspeedV = ourRigidbody.velocity.y;

            //get the animator component used for setting animation
            Animator ourAnimator = GetComponent<Animator>();

            //tell animator what speeds are

            ourAnimator.SetFloat("speed_walk", currentspeedH);
            ourAnimator.SetFloat("player_V", currentspeedV);
        }

    }
}
