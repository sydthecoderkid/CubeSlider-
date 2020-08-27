using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public GameObject Player;

    public GameObject heartone;

     public GameObject hearttwo;

    public GameObject heartthree;

    public static SpriteRenderer thisrenderer;

    private float timer; 

     private float timebetweenhits; 

     private bool canbehit;

    private Color originalcolor;

    public static int timeshit = 0;
    public OneHundredPopup thispopup;
    // Start is called before the first frame update
    void Start()
    {
        thisrenderer = Player.GetComponent<SpriteRenderer>();
         
        originalcolor = thisrenderer.color;
    }

    // Update is called once per frame
    void Update()
    {
        if(thisrenderer.color == Color.red){
              timer += Time.deltaTime;
        }

         if(timer >= 0.1){
            timer = 0;
            thisrenderer.color = originalcolor;
        }

        if(!canbehit){
            timebetweenhits += Time.deltaTime;
        }
        if(timebetweenhits >= 0.3f){
            canbehit = true;
            timebetweenhits = 0;
        }
    }

private void OnTriggerEnter2D(Collider2D other) {
          if(other.gameObject.name.Contains("Bullet") && !other.gameObject.name.Contains("Player")){
              if(!ShieldActivate.shieldactive ||ShieldActivate.shielddrained){
             thispopup.playowanim("OwAnim",2f);
            thisrenderer.color = Color.red;
            if(canbehit){
              timeshit++;

            }
             if(timeshit == 1){
                 darkenheart(heartone);
                canbehit = false;
              }
              if(timeshit == 2 && canbehit){
                 darkenheart(hearttwo);
                 canbehit = false;
              }
              if(timeshit ==3 && canbehit){
                  darkenheart(heartthree);
                  GameOver.EndGame();
             }
              
          }
          }
    }


    private void darkenheart(GameObject heart){
        SpriteRenderer heartrenderer = heart.GetComponent<SpriteRenderer>();
         heartrenderer.color = Color.gray;

    }

}
