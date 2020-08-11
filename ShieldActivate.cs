using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldActivate : MonoBehaviour
{
    public GameObject shield; 

    public static bool shieldactive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q)){
            shield.SetActive(true);
            shieldactive = true;
        }

        else if(Input.GetKeyUp(KeyCode.Q)){
            shield.SetActive(false);
             shieldactive = false;
        }
 

       
    }
}
