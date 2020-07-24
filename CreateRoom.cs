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

    // Start is called before the first frame update
    void Start()
    {
        if (!firstroom)
        {
            createtiles();
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        /*TO DO
         * Randomly select from an array of tiles, and pick their type. Picking lava makes the next tile lava(unless it's the last one) 
         * but a tile can also be have an enemy cylinder, or a cube to jump over. First two can't be in the array.
         */
        if(playepos.transform.position.x > (this.transform.position.x) && PlayerMovement.gamestarted)
        {
            makeroom();
        }

       if(roombuilt && playepos.transform.position.x > lasttile.transform.position.x + 8)
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
        for(int i = 0; i < tiles.Length; i++)
        {
            tiles[i].GetComponent<TileType>().thistile = TileType.Tiletype.NormalTile;
        }

        int tilenumber = random.Next(4);
        int longlava = random.Next(5);

        tiles[tilenumber].GetComponent<TileType>().thistile = assigntiletype();
            if (tiles[tilenumber].GetComponent<TileType>().thistile == TileType.Tiletype.LavaTile && tilenumber != 3 && !haslava)
             {
           
             tiles[tilenumber + 1].GetComponent<TileType>().thistile = TileType.Tiletype.LavaTile;
            
            if(longlava == 1 && tilenumber  <2)
            {
                tiles[tilenumber + 2].GetComponent<TileType>().thistile = TileType.Tiletype.LavaTile; //20% change that there will be a long lava block
            }
            haslava = true;
            }
            
            
        
    }


}
