using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMusic : MonoBehaviour
{
    public AudioSource songone;

    public AudioSource songtwo;

    public AudioSource songthree;

    public AudioSource songfour; 

    public float timer; 

    private  AudioSource currentsong;

    public ArrayList songs = new ArrayList();
    // Start is called before the first frame update
    void Start()
    {
        songs.Add(songone);
        songs.Add(songtwo);
        songs.Add(songthree);
        songs.Add(songfour);

        currentsong = randomsong();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 3 && !currentsong.isPlaying){
              currentsong = randomsong();
               currentsong.Play();
                timer = 0;
        }   
    }

    public AudioSource randomsong(){
         var rand = new System.Random();
        int randomnum = rand.Next(3);
        return (AudioSource) songs[randomnum];
     }
}
