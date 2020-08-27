using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject heartone;
    public GameObject heartwo;
    public GameObject heartthree;
    public static bool gameover = false;
    public GameObject player;
    public TextMeshProUGUI gameovertext;

    public GameObject deathparticles;

    public GameObject restartbutton; 

    private float timer = 0;

    public RestartGame gamerestarter;

    public TextMeshProUGUI totalpoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(deathparticles.activeInHierarchy){
            timer +=Time.deltaTime;
        }
        if(timer >= .18f){
            player.SetActive(false);

        }
        if (gameover && !RestartGame.gamerestarted)
        {
            heartone.GetComponent<SpriteRenderer>().color = Color.gray;
            heartwo.GetComponent<SpriteRenderer>().color = Color.gray;
            heartthree.GetComponent<SpriteRenderer>().color = Color.gray;
            gameovertext.text = "Game Over!";
            restartbutton.SetActive(true);
            deathparticles.SetActive(true);
            totalpoints.text = "Total Points: " + PointCounter.totalpoints;
            
        }
    }

    public static void EndGame()
    {
        PlayerMovement.gamestarted = false;
        gameover = true;
       
    }
}
