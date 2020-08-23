using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAtPlayer : MonoBehaviour
{
    public GameObject player;

    public GameObject enemybullet;

     public GameObject gunholder;


    public GameObject gunstock; 

    public DestroyEnemy destroyenemyscript;

      public GameObject thisenemy;


    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.FindGameObjectWithTag("Player");
        destroyenemyscript = thisenemy.GetComponent<DestroyEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
          timer += Time.deltaTime;
   Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);

        //Get the Screen position of the mouse
        Vector2 mouseOnScreen = (player.transform.position);

        //Get the angle between the points
        float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);

        if (PlayerMovement.gamestarted)
        {
            //transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle - 190)); 
        }
      
        //takes care of the shooting
    if(PlayerMovement.gamestarted && timer >= .7f && !destroyenemyscript.dead && (this.transform.position.x - (player.transform.position.x) < 12) && !GameOver.gameover){
             float rotationamount = -100;
             if(!PlayerMovement.candoublejump && !PlayerMovement.onground){
                 rotationamount = -110;
             }
     if(PlayerMovement.onground){
       rotationamount = -90;
     }
      Vector2 tempspawn = new Vector2(gunstock.transform.position.x, gunstock.transform.position.y);
      if(PlayerMovement.gamestarted){
     Instantiate(enemybullet, tempspawn, gunholder.transform.rotation * Quaternion.Euler (0f, 0,rotationamount ));
        timer = 0;
      }
   }
    }
float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(b.y - a.y, b.x - a.x) * Mathf.Rad2Deg;
    }
       
}
