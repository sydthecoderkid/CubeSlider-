using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour
{

    private float timer; 

    public int totalmovement = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMovement.gamestarted){
            timer +=  Time.deltaTime;
             if(timer >= 45 && PlayerMovement.playerspeed < totalmovement && CameraMovement.movementspeed <totalmovement){
                 PlayerMovement.playerspeed +=5;
                CameraMovement.movementspeed +=5;
                timer = 0;
            }
        }
    }
}
