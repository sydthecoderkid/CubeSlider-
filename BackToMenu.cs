using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BackToMenu : MonoBehaviour
{
    public Button backbutton;
    public Animator fader;

    public AudioSource select;

    public static Scene lastscene;
    // Start is called before the first frame update
    void Start()
    {
         backbutton.onClick.AddListener(BacktoMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BacktoMenu(){
        fader.Play("FadeOut(non-game)");
        SceneManager.LoadScene("Main Menu");
        select.Play();
     }
}
