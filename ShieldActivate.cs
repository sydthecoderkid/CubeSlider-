using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldActivate : MonoBehaviour
{
    Color originalcolor;

    public Image forceimage;

    public static bool shieldactive;

    public static float forceimagefill;

    public static GameObject shield;

    public GameObject shieldone;

    public GameObject shieldtwo;

    public GameObject shieldthree;

    public static bool shielddrained; 

    public GameObject particleone;

    public GameObject particletwo;

    public GameObject particlethree;

    public static bool sentcolors; 

     void Start()
    { 
        originalcolor = new Color(0, 214,221);
        forceimage.fillAmount = 1;
        shield = GameObject.FindGameObjectWithTag("Shield");
          
     }

    // Update is called once per frame
    void Update()
    {
      forceimagefill = forceimage.fillAmount;
       
      if(Input.GetKey(KeyCode.Q) && PlayerMovement.gamestarted){
          shieldactive = true;
          OnShieldHit.hitshield = false;
         shield.SetActive(true);
       }

      else if(!Input.GetKey(KeyCode.Q)){
        shieldactive = false;
           shield.SetActive(false);
         
      }

      

      

    }

   
   

}
