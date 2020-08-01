using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private static PlayerMovement reference = new PlayerMovement();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        if (PlayerMovement.gamestarted && !GameOver.gameover)
        {
           //this.transform.Translate(Vector2.right * (Time.deltaTime * 15f));

        }
    }
}
