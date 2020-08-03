using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropelBullet : MonoBehaviour
{
    public GameObject thisbullet; 
     float countdown = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
         
         countdown += Time.deltaTime;

         if(countdown >= .2){
            Destroy(thisbullet);
         }
         this.transform.Translate(Vector2.down * (Time.deltaTime * 70f));
        
    }



     
}
