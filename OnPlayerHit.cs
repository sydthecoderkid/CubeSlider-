﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlayerHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      private void OnTriggerEnter2D(Collider2D other) {

          if(other.gameObject.name.Contains("Player") && !ShieldActivate.shieldactive){
                  Destroy(this.gameObject);
          }

         
      
    }
}
