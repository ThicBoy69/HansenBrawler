using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMan : Player
{
    public Hand LeftHand;
    public Hand RightHand;
    public Foot LeftFoot;
    public Foot RightFoot;
    public Body MainBody;
    public Head MainHead;
    
    //update method()
    public void Update()
    {
        //If the player presses the D key
        if (Input.GetKey(KeyCode.D))
        {
            //Call the MoveForward() method
            MoveForward();
        }
        //If the player presses the A key
        if (Input.GetKey(KeyCode.A))
        {
            //Call the MoveBackward() method
            MoveBackward();
        }
        //If the player presses the E key
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Call the Punch() method
            Punch();
        }
        //If the player presses the Q key
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Call the Kick() method
            Kick();
        }
    }

    //Moveforward method()
    public void MoveForward()
    {
        
        //Trigger the move forward animation
        Animator animator = GetComponent<Animator>();
        animator.SetTrigger("MoveForward");
    }

    //Movebackward method()
    public void MoveBackward()
    {
        
        //Trigger the move back animation
        Animator animator = GetComponent<Animator>();
        animator.SetTrigger("MoveBack");
    }

    //Punch method via animator()
    public void Punch()
    {
        //Find animator component
        Animator animator = GetComponent<Animator>();
        //Trigger the punch animation
        animator.SetTrigger("Punch");
    }
    //Kick method via animator()
    public void Kick()
    {
        //Find animator component
        Animator animator = GetComponent<Animator>();
        //Trigger the kick animation
        animator.SetTrigger("Kick");
        
    }
    //lock position on y and z axis()
    public void LockPosition()
    {
        //Lock the player's position on the y and z axis
        transform.position = new Vector3(transform.position.x, 0, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

   
}
