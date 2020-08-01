using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropelBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         float countdown = 0;
         
         countdown += Time.deltaTime;

         if(countdown > 2){
               Destroy(this.gameObject);
         } 
         this.transform.Translate(Vector2.down * (Time.deltaTime * 90));
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(this.gameObject);
    }
}
