using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public GameObject thisenemy;

    public ParticleSystem death;

    public GameObject tophalf;
    public GameObject bottomhalf;
    public GameObject stock;

    public float counter;

    private bool dead;

    private float oldy = 0;

public GameObject barrel;
    // Start is called before the first frame update
    void Start()
    {
        
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
             this.transform.position = new Vector2(this.transform.position.x, oldy);
             death.Play();
         }

         if(counter >= 2f){
            Destroy(thisenemy);
         }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        
       if(other.gameObject.name.Contains("Bullet")){
            dead = true;
            barrel.SetActive(false);
           tophalf.SetActive(false);
        //   bottomhalf.GetComponent<Collider2D>().enabled = false;
        oldy = this.transform.position.y;
          thisenemy.GetComponent<Collider2D>().enabled = false;
           stock.SetActive(false);
       }
    }

    
}
