using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
    
{
    public GameObject bullet; 
   public GameObject gunstock;

    public GameObject parent;

    public static bool lookingdown;

    public float shottimer = 0;
    public float yholder = 0;

    public ParticleSystem explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    // Update is called once per frame
    void Update()
    {
        shottimer += Time.deltaTime;
        if(Input.GetMouseButtonDown(1) && shottimer >= 0.2f){
            Vector2 tempspawn = new Vector2(gunstock.transform.position.x, gunstock.transform.position.y);
            float rotationamount = 0;
            for(int i = 0; i < 5; i++){
                rotationamount = (float) (449.239 + (i * 5));
                yholder += (tempspawn.y + 10) ;
               Instantiate(bullet, tempspawn, parent.transform.rotation * Quaternion.Euler (0f, 0,rotationamount));
               explosion.Play();
            }
            shottimer = 0;
        }
        
    }
}
