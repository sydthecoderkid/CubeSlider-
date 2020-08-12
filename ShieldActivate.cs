using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldActivate : MonoBehaviour
{
    public GameObject shield; 

    public static bool shieldactive;

    public GameObject shieldone;
    public GameObject shieldtwo;

    public GameObject shieldthree;

 
    public Color originalcolor; 
    
    public Image forceimage; 

 
      // Start is called before the first frame update
    void Start()
    { 
         originalcolor = new Color(0, 214,221);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q)){
            
            shield.SetActive(true);
             shieldactive = true;
             decreaseshield();
        }

        else if(!Input.GetKey(KeyCode.Q)){
             shield.SetActive(false);
             shieldactive = false;
              refillshield();
        }

       
 

       
    }

   private void decreaseshield(){
        forceimage.fillAmount -= 0.001f;
   }


    private void refillshield(){
     forceimage.fillAmount  += 0.001f;
   }
}
