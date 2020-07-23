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
      // Start is called before the first frame update
    void Start()
    {
        
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
            roombuilt = true;
        }
    }


}
