using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGame : MonoBehaviour
{

    public TextMeshProUGUI textmesh; 

    public TextMeshProUGUI totalpoints;


    public AudioSource select;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && RestartGame.setup && !PauseGame.paused){
             PlayerMovement.gamestarted =true;
             textmesh.text = "";
             totalpoints.text = "";
             select.Play();
        }
    }
}
