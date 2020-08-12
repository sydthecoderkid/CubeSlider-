using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnShieldHit : MonoBehaviour
{
    public SpriteRenderer thisrenderer;

    private float timer; 

    private static Color originalcolor;
    // Start is called before the first frame update
    void Start()
    {
      originalcolor = new Color(0, 214,221);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(thisrenderer.color == Color.green){
            timer += Time.deltaTime;
        }
        if(timer >= 0.1){
            timer = 0;
            thisrenderer.color = originalcolor;
        }
    }

     private void OnTriggerEnter2D(Collider2D other) {
         if(PlayerMovement.onground && this.gameObject.name.Equals("Shield (3)")){
                   thisrenderer.color = originalcolor; 
            }

      else if(other.gameObject.name.Contains("Bullet") && !other.gameObject.name.Contains("Player")){
            thisrenderer.color = Color.green;
            Destroy(other.gameObject);
          }
    } 
}
