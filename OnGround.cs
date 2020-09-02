using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TutorialMovement.onground = true;
        PlayerMovement.onground = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (PlayerMovement.jumped )
        {
             TutorialMovement.onground = false;
            PlayerMovement.onground = false;
        }

    }
}
