using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldActivate : MonoBehaviour
{
    public GameObject shield; 

    public static bool shieldactive;
 

  public static bool shielddrained;
    public Color originalcolor; 
    
    public Image forceimage; 

    public static float forceimagefill; 

    public GameObject shieldone;

    public GameObject shieldtwo;

    public GameObject shieldthree;

    public GameObject shieldoneparticles;
    public GameObject shieldtwoparticles;

    public GameObject shieldthreeparticles;

    private Color drainedcolor;

    public SpriteRenderer shieldcolorone;

    public SpriteRenderer shieldcolortwo;

    public SpriteRenderer shieldcolorthree;

    void Start()
    { 
        originalcolor = new Color(0, 214,221);
       
    }

    // Update is called once per frame
    void Update()
    {
      shieldcolorone = shieldone.GetComponent<SpriteRenderer>();
      shieldcolortwo =  shieldtwo.GetComponent<SpriteRenderer>();
      shieldcolorthree = shieldthree.GetComponent<SpriteRenderer>();
 
        
        forceimagefill = forceimage.fillAmount;
        Color currentcolor = shieldone.GetComponent<SpriteRenderer>().color;
        if(Input.GetKey(KeyCode.Q) && !shielddrained){
            setparticles(true);
            shield.SetActive(true);
             shieldactive = true;
             decreaseshield(currentcolor);
        }

        else if(!Input.GetKey(KeyCode.Q)){
            shieldactive = false;
           shield.SetActive(false);
           refillshield(currentcolor);
        }
         if(forceimagefill == 0 ){
               shieldactive = false;
              shielddrained = true;
             setparticles(false);
              }

       
   }

   private void resetcolors(Color newcolor){
       shieldone.GetComponent<SpriteRenderer>().color = newcolor;
       shieldtwo.GetComponent<SpriteRenderer>().color = newcolor;
       shieldthree.GetComponent<SpriteRenderer>().color = newcolor;
   }

   private void setparticles(bool fillvalue){
       shieldoneparticles.SetActive(fillvalue);
       shieldtwoparticles.SetActive(fillvalue);
       shieldthreeparticles.SetActive(fillvalue);
   }

   private void decreaseshield(Color currentspritecolor){
       if(!OnShieldHit.hitshield){
       float colorg = currentspritecolor.g -  0.0007f;
       float colorb = currentspritecolor.b -  0.0007f;
        forceimage.fillAmount -= 0.001f;
        Color darkercolor = new Color(currentspritecolor.r, colorg, colorb, currentspritecolor.a);
        resetcolors(darkercolor);
       }

   }


   
    private void refillshield(Color currentspritecolor){
        shielddrained = false;
        float colorg = currentspritecolor.g +  0.0007f;
       float colorb = currentspritecolor.b + 0.0007f;
     forceimage.fillAmount  += 0.001f;
      Color darkercolor = new Color(originalcolor.r, colorg, colorb, originalcolor.a);
        resetcolors(darkercolor);
     
   }
}
