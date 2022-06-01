using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed = 5.0f;
    public Rigidbody2D rb;
    Vector2 movement;

    public GameObject textBox;


    // Update is called once per frame
    void Update()
    {
        //input
       
        movement.x = Input.GetAxisRaw("Horizontal"); //value between -1 and 1 for left/right & a/d
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime); //moves rigid body to a new position & collide with anything in the way
                                                                                   //Time.fixedDeltaTime = time since method was last called - keeps movement speed constant
 

    }
}
