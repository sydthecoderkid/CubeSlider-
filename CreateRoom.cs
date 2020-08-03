using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreateRoom : MonoBehaviour
{
    public GameObject roomprefab;

    public GameObject thisroom;

    public GameObject playepos;

    public GameObject lasttile;

    private static bool roombuilt = false;

    public GameObject[] tiles = new GameObject[4];


    private bool haslava = false;

    public System.Random random = new System.Random();

    public static bool firstroom = true;

    public GameObject turret;

    public GameObject turrettwo;
    // Start is called before the first frame update
    void Start()
    {
        turret.SetActive(false);
        turrettwo.SetActive(false);
        if (!firstroom)
        {
            createtiles();
            spawnturrets();
        }
        
        
    }

    private void spawnturrets()
    {
        int randomturret = random.Next(8);
        if(randomturret == 1 || randomturret == 2)
        {
            turret.SetActive(true);
        }

        if(randomturret == 3 || randomturret == 4){
            turrettwo.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
         
        if(playepos.transform.position.x > (this.transform.position.x) && PlayerMovement.gamestarted)
        {
            makeroom();
        }

       if(roombuilt && playepos.transform.position.x > lasttile.transform.position.x + 8) //OG plus 8
        {
            Destroy(thisroom);
            roombuilt = false;

        }
    }

     
    public void makeroom()
    {
        if (!roombuilt)
        {
            Vector2 newroompos = new Vector2(lasttile.transform.position.x + 15, roomprefab.transform.position.y);
            Instantiate(roomprefab, newroompos, Quaternion.identity);
            firstroom = false;
            roombuilt = true;
        }
    }

    public TileType.Tiletype assigntiletype()
    {
         
        
        if (!haslava)
        {
 
            return TileType.Tiletype.LavaTile;
        }
            
        
        return TileType.Tiletype.NormalTile;
    }
    
    public void createtiles()
    {
        /*Explanation: This method sets all the tiles type to normal tiles, then randomly selects a tile from the array of tiles in the room. If the 
         *tile isn't the last in the array, it sets that tile and the one next to it as lava. There's also a 1/5 chance of a "long lava"
         * which occurs if the tile selected is the first or second one. Then the next three tiles will become lava. 
         * 
         * */
        for(int i = 0; i < tiles.Length; i++)
        {
            tiles[i].GetComponent<TileType>().thistile = TileType.Tiletype.NormalTile;
        }

        int tilenumber = random.Next(4);
        int longlava = random.Next(5);

        if(tilenumber != tiles.Length-1 && !haslava) //Assigns tile if it's not the last value in the array. This is done because the lava always comes in pairs of two or more.
        {
            tiles[tilenumber].GetComponent<TileType>().thistile = assigntiletype();
        }
        if (tiles[tilenumber].GetComponent<TileType>().thistile == TileType.Tiletype.LavaTile && tilenumber != 3 && !haslava)
             {
           
             tiles[tilenumber + 1].GetComponent<TileType>().thistile = TileType.Tiletype.LavaTile;
            
            if(longlava == 1 && tilenumber  <2)
            {
                tiles[tilenumber + 2].GetComponent<TileType>().thistile = TileType.Tiletype.LavaTile; //20% change that there will be a long lava block
            }
            haslava = true;
        }

                if (tiles[3].GetComponent<TileType>().thistile == TileType.Tiletype.NormalTile)
                {
                     int enemytile = random.Next(3);
                     if(enemytile == 1)
                     {
                          tiles[3].GetComponent<TileType>().thistile = TileType.Tiletype.EnemyTile;
                     }

                  if (enemytile == 2)
                  {
                      tiles[0].GetComponent<TileType>().thistile = TileType.Tiletype.EnemyTile;
                  }

                 }
        

        




    }


}
