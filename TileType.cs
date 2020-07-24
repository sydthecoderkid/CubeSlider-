using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class TileType : MonoBehaviour
{
    public Tiletype thistile = Tiletype.NormalTile;
    public int timeswritten = 0;

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

            thiscolor.color = Color.red;
        }

        if (thistile != Tiletype.LavaTile)
        {
            SpriteRenderer thiscolor = this.GetComponent<SpriteRenderer>();
            transform.position = new Vector2(this.transform.position.x, -4.03f);
            thiscolor.color = new Color32(195, 195, 195, 255);
        }


    }
}
