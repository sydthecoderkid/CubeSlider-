using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFire : MonoBehaviour
{
    GameObject player; 

    public GameObject shooter; 

    public GameObject enemybullet;

    float timer;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
         timer += Time.deltaTime;
         if(timer >= 1){
        Vector2 tempspawn = new Vector2(shooter.transform.position.x, shooter.transform.position.y - 1);
     Instantiate(enemybullet, tempspawn, shooter.transform.rotation * Quaternion.Euler (0f, 0,180));
     timer = 0;
         }
     }

     
       
}
