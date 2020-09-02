using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTurret : MonoBehaviour
{
    public GameObject shooter;

    public GameObject turrtepiecetwo;

    public ParticleSystem blownup;

    public bool dead;

    public OneHundredPopup thispopup;

    public GameObject canvas; 

    public string animname; 

    public AudioSource deathnoise;

    public TurretFire thisfire; 
    // Start is called before the first frame update
    void Start()
    {
        shooter.SetActive(true);
        turrtepiecetwo.SetActive(true);
        canvas.SetActive(false);

         dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      private void OnCollisionEnter2D(Collision2D other) {
       if(other.gameObject.name.Contains("Bullet")){
         shooter.SetActive(false);
          turrtepiecetwo.SetActive(false);
          if(!dead){
                PointCounter.totalpoints += 50;
            }
           dead = true;
          blownup.Play();
          deathnoise.Play();
          canvas.SetActive(true);
            thisfire.blownup = true;
            thispopup.playturretanim(animname, 1.5f);
            
       }
    }
}
