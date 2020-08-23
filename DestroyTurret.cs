using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTurret : MonoBehaviour
{
    public GameObject turretpieceone;

    public GameObject turrtepiecetwo;

    public ParticleSystem blownup;

    public bool dead;

    public OneHundredPopup thispopup;

    public GameObject canvas; 

    public string animname; 
    // Start is called before the first frame update
    void Start()
    {
        turretpieceone.SetActive(true);
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
         turretpieceone.SetActive(false);
          turrtepiecetwo.SetActive(false);
           dead = true;
          blownup.Play();
          canvas.SetActive(true);
            thispopup.playturretanim(animname, 1.5f);

       }
    }
}
