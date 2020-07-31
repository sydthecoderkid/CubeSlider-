using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
    
{
   public GameObject gunstock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 startPos = new Vector3(gunstock.transform.position.x + 5, gunstock.transform.position.y);
           // RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 100f );
            Debug.DrawRay(startPos, Vector3.right * .8f, Color.green, 100f);
        }
    }
}
