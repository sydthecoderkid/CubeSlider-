﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFire : MonoBehaviour
{
    GameObject player; 

    public GameObject shooter; 

    public GameObject enemybullet;

    public AudioSource turretfire; 
 
    float timer;

     public bool blownup;

     public GameObject holder; 

     // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
     }

    // Update is called once per frame
    void Update()
    {
         timer += Time.deltaTime;
          if(timer >= 1 && PlayerMovement.gamestarted && !GameOver.gameover && holder.activeInHierarchy && !blownup){
        Vector2 tempspawn = new Vector2(shooter.transform.position.x, shooter.transform.position.y - 1);
         Instantiate(enemybullet, tempspawn, shooter.transform.rotation * Quaternion.Euler (0f, 0,180));
              timer = 0;
              if(!turretfire.isPlaying){
              turretfire.Play();
              }
          }

         
        

          

         
     }

    
     
     
       
}
