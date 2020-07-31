using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     public static Rigidbody2D playercomponent = new Rigidbody2D();

     public float playerspeed = 15f;

     public static bool gamestarted;

    public static bool jumped = false;

    public static bool canjump = true;

    private float thrust = 480f; //If increasing player speed, thrust must be adjusted

    public static bool onground = false;

    public static bool candoublejump = false;

    private static float playery = -2.5f;


    public static float playerx;


    // Start is called before the first frame update
    void Start()
    {
         playercomponent = GetComponent<Rigidbody2D>(); 
           
    }

    // Update is called once per frame
    void Update()
    {

         if(this.transform.position.y < playery)
        {
            playercomponent.gravityScale = 5f;
        }

        playerx = playercomponent.transform.position.x;

        if (gamestarted && !GameOver.gameover){
            this.transform.Translate(Vector2.right * (Time.deltaTime * playerspeed));
            if (onground)
            {
                 playerspeed = 15f;
                canjump = true;
                jumped = false;
                candoublejump = false;
            }

          else if (!onground)
            {
                playercomponent.gravityScale = 2.5f; //Pulls the cube back to earth quicker //og: 2

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
                    playerspeed = 15.1f;
                }

               else if(!onground && candoublejump)
                {
                    playercomponent.velocity = new Vector2(playercomponent.velocity.x, 0);
                    if (transform.position.y < 5)
                    {
                        playercomponent.AddForce(transform.up * (thrust + 10));
                    }
                    playerspeed = 15.1f;
                    candoublejump = false;
                    onground = false;
                }

            }

            
        }

        
    }
    
    

   
   
}
