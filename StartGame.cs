using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGame : MonoBehaviour
{

    public TextMeshProUGUI textmesh; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
             PlayerMovement.gamestarted =true;
             textmesh.text = "";
        }
    }
}
