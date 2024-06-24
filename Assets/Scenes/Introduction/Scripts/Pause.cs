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

      public void OnClickContinue() {
       
        gameObject.SetActive(false);
        Time.timeScale = 1;
        Wizard.PauseA = false;
    }

    public void OnClickTitleScreen()
    {
       
            SceneManager.LoadScene("GameManager");
            GameManager.GMstate = "Menü";

        
    }
}
