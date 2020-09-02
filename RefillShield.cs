using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RefillShield : MonoBehaviour
{
    public GameObject shieldone;
    public GameObject shieldtwo;
    public GameObject shieldthree;

    public Image forceimage; 

    public Color originalcolor;

    public static Color precolor; 
     public static Color shieldthreecolor;
      public static Color shieldtwocolor;

 
    // Start is called before the first frame update
    void Start()
    {
         originalcolor = new Color(0, 214,221);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(!Input.GetKey(KeyCode.Q)){
                shieldthreecolor = shieldthree.GetComponent<SpriteRenderer>().color;
                if(PlayerMovement.gamestarted){
                refillshield(shieldthreecolor);
                }
        }
    }
 private void refillshield(Color currentspritecolor){
     if(shieldone.GetComponent<SpriteRenderer>().color == Color.green && shieldtwo.GetComponent<SpriteRenderer>().color == Color.green && shieldthree.GetComponent<SpriteRenderer>().color == Color.green){
         Debug.Log("Green shields");
     }
     if(currentspritecolor == Color.green){
  
    float colorg = precolor.g +  0.0014f;
       float colorb = precolor.b + 0.0014f;
     forceimage.fillAmount  += 0.001f;
      Color darkercolor = new Color(precolor.r, colorg, colorb, precolor.a);
        resetcolors(darkercolor);
     }
   else if(currentspritecolor != Color.green){
        float colorg = currentspritecolor.g +  0.0014f;
       float colorb = currentspritecolor.b + 0.0014f;
     forceimage.fillAmount  += 0.001f;
      Color darkercolor = new Color(originalcolor.r, colorg, colorb, originalcolor.a);
        resetcolors(darkercolor);
     }
      
     
   }

    private void resetcolors(Color newcolor){
       shieldone.GetComponent<SpriteRenderer>().color = newcolor;
       shieldtwo.GetComponent<SpriteRenderer>().color = newcolor;
       shieldthree.GetComponent<SpriteRenderer>().color = newcolor;
   }

   
}

   



