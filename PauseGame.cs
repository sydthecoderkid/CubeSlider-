using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    public GameObject pausemenu;
    
    public static bool paused; 
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Escape) && !pausemenu.activeInHierarchy){
                pausemenu.SetActive(true);
                PlayerMovement.gamestarted = false;
                paused = true;
                if(PlayerMovement.playercomponent != null){
                PlayerMovement.playercomponent.constraints = RigidbodyConstraints2D.FreezePositionY;
                }
                else{
                    TutorialMovement.playercomponent.constraints = RigidbodyConstraints2D.FreezePositionY;
                }
        }

        else if(Input.GetKeyDown(KeyCode.Escape) && pausemenu.activeInHierarchy){
            pausemenu.SetActive(false);
            PlayerMovement.gamestarted = true;
       
                 if(PlayerMovement.playercomponent != null){
                PlayerMovement.playercomponent.constraints = RigidbodyConstraints2D.FreezeRotation;
                 }

                 else{
                      TutorialMovement.playercomponent.constraints = RigidbodyConstraints2D.FreezeRotation;
                 }
            paused = false;
        }
        
    }
}
