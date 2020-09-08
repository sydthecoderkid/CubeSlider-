using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ToggleMusic : MonoBehaviour
{
    public TextMeshProUGUI on;

    public Button musicbutton;

    private Color originalcolor;

    private Color buttoncolor; 

    public static bool musicison = true;

    public AudioSource select;
    // Start is called before the first frame update
    void Start()
    {
         musicbutton.onClick.AddListener(PlayMusic);
         originalcolor = on.color;
         buttoncolor = musicbutton.image.color;
         if(!musicison){
             on.text = "Off";
             on.color =Color.red;
         }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayMusic(){
        select.Play();
        if(on.text.Equals("On")){
            on.text = "Off";
            on.color =Color.red;
            musicison = false;
            
        }
        else{
            on.text = "On";
            on.color =originalcolor;
            musicison = true;
        }
    }
}
