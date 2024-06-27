using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
      GameManager.Instance.PauseAC =(this.gameObject);
      gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

       

    }

      public void OnClickContinue(){
       
        gameObject.SetActive(false);
        ToggelContinue();
      }

      public void OnClickTitleScreen()
      {
       
            SceneManager.LoadScene("GameManager");
            GameManager.GMstate = "Menü";

            
        
      }

      public void ToggelBreak() { 
        

        
        Wizard.PauseA = true;
        Fireball.PauseA=true;
        Time.timeScale = 0f;

    
      }

      public void ToggelContinue()
      {

        Wizard.PauseA = false;
        Fireball.PauseA = false;
        Time.timeScale = 1f;

      }
}
