using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneHundredPopup : MonoBehaviour
{
    public static Animator popupanim; 
    public GameObject popup;

public static bool playingpopup; 

private float timer; 
     // Start is called before the first frame update
    void Start()
    {
        popupanim = popup.GetComponent<Animator>();
        playingpopup = false;
    }

    // Update is called once per frame
    void Update()
    {
         
        if(playingpopup){
            timer += Time.deltaTime;
        }

        if(timer >= .5f){
         //   popup.SetActive(false);
        }
    }

    public static void playpointcounter(string anim){
          popupanim.Play(anim);
          playingpopup = true;
     }
}
