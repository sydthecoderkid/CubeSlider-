﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{

    public GameObject roomprefab;

    public GameObject background; 

    public Animator fadein;

    public Button restartbutton; 

    public TextMeshProUGUI text;
    public GameObject restartbuttonobj;

    public static bool gamerestarted = false; 

    public GameObject player; 

    public float timer = 0;

    private bool countdown = false; 

    public static bool setup;

    public AudioSource restartbuttonaudio;
    // Start is called before the first frame update
    void Start()
    {
        restartbutton.onClick.AddListener(OnClick);
       
             fadein.Play("FadeOut");
            gamerestarted = false;
            setup = true;
        

     }

    // Update is called once per frame
    void Update()
    {
        if(countdown){
            timer += Time.deltaTime;
        }
        if(timer >= .5f && gamerestarted){
              timer = 0;
              resetvalues();
          }
         
    }

 void OnClick(){
      
         text.text = "";
         restartbuttonobj.SetActive(false);
         gamerestarted = true;
         restartbuttonaudio.Play();
          fadein.Play("FadeIn");
          countdown = true; 
          
  }

 public static void resetvalues(){
     setup = false;
     SceneManager.LoadScene("GameScene");
      GameOver.gameover =false;
      TakeDamage.timeshit = 0;
       PlayerMovement.gamestarted =false;
      CreateRoom.firstroom = true;
      CreateRoom.roombuilt = false;  
      ShieldActivate.shielddrained = false;
      PlayerMovement.playerspeed = 15;
      CameraMovement.movementspeed = 15;
        StartGame.timesclicked = 0;
      PointCounter.totalpoints = 0;
       PauseGame.paused = false;
 }
     

    
}
