using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public GameObject thisenemy;

    public bool playedcounter; 

    public ParticleSystem death;

    public GameObject tophalf;
    public GameObject bottomhalf;
    public GameObject stock;

    public float counter;

    public bool dead = false;

    private float oldy = 0;

public GameObject barrel;

public OneHundredPopup thispopup;
    // Start is called before the first frame update
    void Start()
    {
        thispopup = this.GetComponent<OneHundredPopup>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMovement.playerx > this.transform.position.x + 10)
        {
            Destroy(thisenemy);
         }

         if(dead){
             counter += Time.deltaTime;
            
         }

         if(counter >= 9f){
            Destroy(thisenemy);
         }
    }

    private void OnCollisionEnter2D(Collision2D other) {
       if(other.gameObject.name.Contains("Bullet") && !dead){

           dead = true;
           thisenemy.gameObject.GetComponent<Collider2D>().enabled = false;
            barrel.SetActive(false);
           tophalf.SetActive(false);
           stock.SetActive(false);
           if(!playedcounter){
           thispopup.playpointcounter("100Popup", .5f);
            playedcounter = true;
             PointCounter.totalpoints += 100;
           }
               death.Play();           

           
       }

       else if(other.gameObject.name.Equals("Player")){
           GameOver.EndGame();
       }
    }

    
}
