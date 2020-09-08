using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SetListener : MonoBehaviour
{
    public Button Playbutton;
    public Button TutorialButton;

    public Button OptionsButton;

    public Animator fader;

    public AudioSource select;
    // Start is called before the first frame update
    void Start()
    {
        Playbutton.onClick.AddListener(PlayClick);
        TutorialButton.onClick.AddListener(TutorialClick);
        OptionsButton.onClick.AddListener(OptionsClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void PlayClick(){
        fader.Play("FadeOut(non-game)");
        select.Play();
          RestartGame.resetvalues();


    }

    void TutorialClick(){
        fader.Play("FadeOut(non-game)");
        SceneManager.LoadScene("Tutorial");
         select.Play();

    }

    void OptionsClick(){
        fader.Play("FadeOut(non-game)");
        BackToMenu.lastscene.name = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Options");
         select.Play();

    }
}
