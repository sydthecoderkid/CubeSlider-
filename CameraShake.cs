using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    // Start is called before the first frame update
   
    
    void Start()
    {
        
    }

     private void Update() {
         
    }

    public void shakecamera(bool shaking){
        if(shaking){
        this.GetComponent<Animator>().Play("CameraShakeAnim");
        }
        shaking =false;
        
    }
   
  
}

