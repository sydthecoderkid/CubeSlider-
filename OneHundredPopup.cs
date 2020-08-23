using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneHundredPopup : MonoBehaviour
{
    public Animator popupanim; 
    public GameObject popup;

public bool playingpopup; 

 

 
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
         popup.SetActive(false);
          
         timer = 0;
        }
    }

    public  void playpointcounter(string anim, float timer){
          popupanim.Play(anim);
          playingpopup = true;
      }

      public void playowanim(string anim, float timer){
          popupanim.Play("OwAnim");
     }

     public void playturretanim(string anim, float timer){
          popupanim.Play(anim);
        }
}
