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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover)
        {
            heartone.GetComponent<SpriteRenderer>().color = Color.gray;
            heartwo.GetComponent<SpriteRenderer>().color = Color.gray;
            heartthree.GetComponent<SpriteRenderer>().color = Color.gray;
            gameovertext.text = "Game Over!";
            player.SetActive(false);
        }
    }

    public static void EndGame()
    {
        PlayerMovement.gamestarted = false;
        gameover = true;
       
    }
}
