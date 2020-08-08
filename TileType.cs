using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class TileType : MonoBehaviour
{
    public Tiletype thistile = Tiletype.NormalTile;
    bool islava =false;
    public GameObject enemy;
    private bool spawnedenemy;
    public static bool destroyenemy = false;
    private GameObject enemyclone;

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
            if (!spawnedenemy)
            {
                createenemy();
            }
            thiscolor.color = new Color32(195, 195, 195, 255);
        }

        
    }

    private void createenemy()
    {
        Vector2 enemypos = new Vector2(this.transform.position.x + 6, this.transform.position.y + 10f);
       enemyclone =  Instantiate(enemy, enemypos, Quaternion.identity);
        spawnedenemy = true;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (islava && collision.gameObject.tag.Equals("Player"))
        {
             GameOver.EndGame();

        }
    }

    
}
