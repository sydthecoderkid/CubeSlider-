using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class TileType : MonoBehaviour
{
    public Tiletype thistile = Tiletype.NormalTile;
    public int timeswritten = 0;
    bool islava =false;

    public enum Tiletype
    {
        LavaTile,
        EnemyTile,
        NormalTile,
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(thistile == Tiletype.LavaTile)
        {
            SpriteRenderer thiscolor = this.GetComponent<SpriteRenderer>();

            transform.position = new Vector2(this.transform.position.x, -4.8f);
            islava = true;
            thiscolor.color = Color.red;
            
        }

        else if (thistile == Tiletype.NormalTile)
        {
            SpriteRenderer thiscolor = this.GetComponent<SpriteRenderer>();
            transform.position = new Vector2(this.transform.position.x, -4.03f);

            thiscolor.color = new Color32(195, 195, 195, 255);
        }

       else if (thistile == Tiletype.EnemyTile)
        {
            SpriteRenderer thiscolor = this.GetComponent<SpriteRenderer>();
            transform.position = new Vector2(this.transform.position.x, -4.03f);

            thiscolor.color = Color.green;
        }





    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        if (islava)
        {
             GameOver.EndGame();

        }
    }
}
