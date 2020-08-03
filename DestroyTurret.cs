using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTurret : MonoBehaviour
{
    public GameObject turretpieceone;

    public GameObject turrtepiecetwo;

    public ParticleSystem blownup;
    // Start is called before the first frame update
    void Start()
    {
        turretpieceone.SetActive(true);
        turrtepiecetwo.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      private void OnCollisionEnter2D(Collision2D other) {
       if(other.gameObject.name.Contains("Bullet")){
         turretpieceone.SetActive(false);
          turrtepiecetwo.SetActive(false);
          blownup.Play();
       }
    }
}
