using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using System;
public class RandomColors : MonoBehaviour
{
    public static ArrayList colors = new ArrayList();
    // Start is called before the first frame update
    void Start()
    {
       
            }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static Color selectcolor(){
 
 
        colors.Add(new Color(.09f, .02f,.2f));
          colors.Add(new Color(0.12f, 0.1f,0.19f));
           colors.Add(new Color(0.18f, 0f,0f));
           colors.Add(new Color(0.4f, 0.1f,0f));
            colors.Add(new Color(0.1f, 0.22f,0.35f));
             colors.Add(new Color(0f, 0.1f,0f));
              colors.Add(new Color(0.1f, 0.1f,0.1f));


        
        var rand = new System.Random();
        int randomnum = rand.Next(6);
        return  (Color) colors[randomnum];

    }
}
