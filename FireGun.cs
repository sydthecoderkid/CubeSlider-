using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
    
{
    public GameObject bullet; 
   public GameObject gunstock;
    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(1)){
           Instantiate(bullet, gunstock.transform.position, transform.rotation * Quaternion.Euler (0f, 180f,0));
        }
        
    }
}
