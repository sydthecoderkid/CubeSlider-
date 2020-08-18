using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnShieldHit : MonoBehaviour
{
    public SpriteRenderer thisrenderer;

    private float timer; 

    private static Color originalcolor;

     private static Color finalcolor;

     private static Color drainedcolor;

     public static bool hitshield = false;

    // Start is called before the first frame update
    void Start()
    {
      originalcolor = new Color(0, 214,221);
      finalcolor = new Color(0, 214,221);
      drainedcolor = new Color32(0, 19, 20, 255 );
    }

    // Update is called once per frame
    void Update()
    {
        if(ShieldActivate.forceimagefill == 1 && thisrenderer.color != finalcolor){
          thisrenderer.color = finalcolor;

        }
        
         if(thisrenderer.color == Color.green){
            timer += Time.deltaTime;
        }
        if(timer >= 0.1){
            timer = 0;
            thisrenderer.color = originalcolor;
            hitshield = false;
        }
    }

     private void OnTriggerEnter2D(Collider2D other) {
        
         if(PlayerMovement.onground && this.gameObject.name.Equals("Shield (3)")){
                   thisrenderer.color = originalcolor; 
            }

      else if(other.gameObject.name.Contains("Bullet") && !other.gameObject.name.Contains("Player") && !ShieldActivate.shielddrained){
          hitshield = true;
           originalcolor = thisrenderer.color;
            thisrenderer.color = Color.green;
            Destroy(other.gameObject);
          }
    } 
}
