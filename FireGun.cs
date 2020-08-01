using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
    
{
    public GameObject bullet; 
   public GameObject gunstock;

    public GameObject parent;

    public static bool lookingdown;
    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(1)){
            Vector2 tempspawn = new Vector2(gunstock.transform.position.x + .4f, gunstock.transform.position.y);
           Instantiate(bullet, tempspawn, parent.transform.rotation * Quaternion.Euler (0f, 0f,449.239f));
        }
        
    }
}
