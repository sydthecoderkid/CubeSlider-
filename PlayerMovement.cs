﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     public static Rigidbody2D playercomponent = new Rigidbody2D();

     public float playerspeed = .1f;

     public static bool gamestarted;

    public static bool jumped = false;

    public static bool canjump = true;

    private float thrust = 550f;

    public static bool onground = false;

    public static bool candoublejump = false;

    
    // Start is called before the first frame update
    void Start()
    {
         playercomponent = GetComponent<Rigidbody2D>(); 
           
    }

    // Update is called once per frame
    void Update()
    {

        /*TO DO
         * Add double jump- increase thrust on second jump
         * 
         */

        if (gamestarted){
            this.transform.Translate(Vector2.right * playerspeed);
            if (onground)
            {
                 playerspeed = .1f;
                canjump = true;
                jumped = false;
                candoublejump = false;
            }

          else if (!onground)
            {
                playercomponent.gravityScale = 2f; //Pulls the cube back to earth quicker 

            }
 

            if (Input.GetMouseButtonDown(0))
            {
                
                if (onground)
                {
                    playercomponent.AddForce(transform.up * thrust);
                    jumped = true;
                    canjump = false;
                    candoublejump = true;
                    onground = false; //Signals the player has jumped, so they are no longer on the ground 
                    playerspeed = .101f;
                }

               else if(!onground && candoublejump)
                {
                    playercomponent.velocity = new Vector2(playercomponent.velocity.x, 0);
                    playercomponent.AddForce(transform.up * thrust);
                    playerspeed = .101f;
                    candoublejump = false;
                    onground = false;
                }

            }

            if (Input.GetMouseButtonUp(0))
            {
                playerspeed = .1f;
            }
        }

        
    }
    
    

   
   
}
