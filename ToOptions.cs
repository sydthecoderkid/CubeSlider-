using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToOptions : MonoBehaviour
{
    public Button optionsbutton;

    public Animator fader;

    public AudioSource select;
    // Start is called before the first frame update
    void Start()
    {
        optionsbutton.onClick.AddListener(SwitchToOptions);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SwitchToOptions(){
           fader.Play("FadeOut(non-game)");
           BackToMenu.lastscene = SceneManager.GetActiveScene();
           SceneManager.LoadScene("Options");
           select.Play();
    }
}
