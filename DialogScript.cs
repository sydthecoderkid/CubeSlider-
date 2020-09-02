﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class DialogScript : MonoBehaviour
{
    public TextMeshProUGUI Dialog;
    private string empty = "";
    private string currentmessage;
    private string firstmessage;

    private string secondmessage;
    private string thirdmessage;

    
    private float time;
    private float secondtimer;
   private Scene scene;
    private int indexer;
    private int count = 0;
 
    private bool finalmessage = false;
 
     private bool switchmessage = false;
     public String currentscene;
    float timetowrite;

    int currentmessagenum = 0;

    ArrayList messages = new ArrayList();
    // Start is called before the first frame update
    void Start()
    {
         
               this.loadmessages();
      
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMovement.gamestarted){
         Dialog.text = empty;
          time += Time.deltaTime;
            if(currentmessage != null){
            indexer = currentmessage.Length;
            timetowrite = (0.06f * currentmessage.Length);
            }

            if(empty.Equals(currentmessage)){
                    switchmessage = true;
            }

  if(secondtimer >= timetowrite && switchmessage){
          nextmessage();
        time = 0;
        secondtimer = 0;
     }
     if(time >= 0.1 && currentmessage != null && !finalmessage){
         displaytext();
        secondtimer += Time.deltaTime;
     }
   }
  }

    public void displaytext(){
        //this method is what makes the text look as though its being typed
        char[] holder;
      holder = currentmessage.ToCharArray(0,indexer); //Translates the given message into characters
      if(count != currentmessage.Length && PlayerMovement.gamestarted){
      empty += holder[count]; //Adds a character to the end of the displayed message
      count++;
      }
       

    }

    public void nextmessage(){
        empty = "";
        count = 0;
        if(currentmessagenum != messages.Count - 1){
         currentmessagenum++;
       }
       else{
           finalmessage = true;
       }
       currentmessage = (String) messages[currentmessagenum];
        switchmessage = false;
          
    }

    public void loadmessages(){
       
         messages.Add( this.firstmessage = "Hey. I'm gonna give you some tips.");
          messages.Add(this.secondmessage= "First of all. Left click to jump. Or use spacebar, up to you. Click twice to double jump.");
           messages.Add(this.thirdmessage = "Second of all. Right click to shoot your badass shotgun.");
           messages.Add("Third of all. There are gonna be some bad guys. Shoot em. I swear It's legal.");
           messages.Add("Fourth of all. They can shoot too. So hold q, and pull up your shield.");
           messages.Add("Your shield will ding when it's full.");
           messages.Add("Just be sure to watch the bar in the top left. If it runs out, your shield'll go dark.");
           messages.Add("And if that happens, the bad dudes can shoot you.");
            messages.Add("I think that's it. You can hit escape and head back to the main menu now. But... ");
             messages.Add("Thanks for playing. I really appreciate it. :) ");
             messages.Add("okaygonow");
            this.currentmessage = this.firstmessage;
      

    }
}
