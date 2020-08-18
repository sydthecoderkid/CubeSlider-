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

    private Color originalcolor;

    private int timeshit = 0;
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
    }

private void OnTriggerEnter2D(Collider2D other) {
          if(other.gameObject.name.Contains("Bullet") && !other.gameObject.name.Contains("Player") && !ShieldActivate.shieldactive){
             thisrenderer.color = Color.red;
             timeshit++;
             if(timeshit == 1){
                 darkenheart(heartone);
              }
             else if(timeshit == 2){
                 darkenheart(hearttwo);
              }
             else if(timeshit ==3){
                  darkenheart(heartthree);
                  GameOver.EndGame();
             }
              
          }
    }


    private void darkenheart(GameObject heart){
        SpriteRenderer heartrenderer = heart.GetComponent<SpriteRenderer>();
         heartrenderer.color = Color.gray;

    }

}
