using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecreaseShield : MonoBehaviour
{

    private SpriteRenderer thisrenderer;
    public Image forceimage; 

    Color originalcolor; 

    Color drainedcolor;

    public static Color currentcolor;


    public static bool decreasing;

    public GameObject particleone;

    public GameObject particletwo;

    public GameObject particlethree;

    
    // Start is called before the first frame update
    void Start()
    {
        thisrenderer = GetComponent<SpriteRenderer>();
        originalcolor = new Color(0, 214,221);
        drainedcolor = new Color32(0, 19, 20, 255 );
        
        
     }

    // Update is called once per frame
    void Update()
    {
        if(ShieldActivate.shieldactive){
       decreaseshield(this.GetComponent<SpriteRenderer>().color);
       currentcolor  = this.GetComponent<SpriteRenderer>().color;   
         particleone.SetActive(true);
          particletwo.SetActive(true);
          particlethree.SetActive(true);   
    }

    if(ShieldActivate.shielddrained){
        this.GetComponent<SpriteRenderer>().color = drainedcolor;
    }

     

       
    }

     private void resetcolors(Color newcolor){
        thisrenderer.color = newcolor;
       
   }

   private void decreaseshield(Color currentspritecolor){
         RefillShield.filled = false;
       if(forceimage.fillAmount == 0){
           ShieldActivate.shieldactive = false;
           ShieldActivate.shielddrained = true;
          this.GetComponent<SpriteRenderer>().color = Color.black;
          particleone.SetActive(false);
          particletwo.SetActive(false);
          particlethree.SetActive(false);

       }
       else if( !OnShieldHit.hitshield && forceimage.fillAmount > 0){
           
        float colorg = this.GetComponent<SpriteRenderer>().color.g -  .0016f;
       float colorb = this.GetComponent<SpriteRenderer>().color.b -  .0016f;
       ShieldActivate.shielddrained = false;
       ShieldActivate.shieldactive = true;
        forceimage.fillAmount -= 0.0004f;
         if(colorg > .05f && colorb >.05f){
        Color darkercolor = new Color(this.GetComponent<SpriteRenderer>().color.r, colorg, colorb, this.GetComponent<SpriteRenderer>().color.a);
        this.GetComponent<SpriteRenderer>().color = darkercolor;
        resetcolors(darkercolor);
       }
       }

        

   }

   

}
