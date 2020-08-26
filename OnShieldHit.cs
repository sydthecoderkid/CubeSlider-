using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnShieldHit : MonoBehaviour
{
    public SpriteRenderer thisrenderer;

    private float timer; 

    public static Color originalcolor;

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
            thisrenderer.color = this.GetComponent<SpriteRenderer>().color;
         if(thisrenderer.color == Color.green){
              timer += Time.deltaTime;
        }
        if(timer >= 0.3){
            thisrenderer.color = RefillShield.precolor;
            hitshield = false;
             timer = 0;

        }
    }

     private void OnTriggerEnter2D(Collider2D other) {
     
       if(other.gameObject.name.Contains("Bullet") && !other.gameObject.name.Contains("Player") && ShieldActivate.shieldactive ){
            if(ShieldActivate.shieldactive || !ShieldActivate.shielddrained)
             originalcolor = thisrenderer.color;
             RefillShield.precolor = originalcolor;
            thisrenderer.color = Color.green;
            hitshield = true;
             Destroy(other.gameObject);
          }
    } 
}
