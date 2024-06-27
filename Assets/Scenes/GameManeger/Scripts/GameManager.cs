using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static string GMstate = "";
    static float Timer  = 180f;

    public int Score;

    public static GameManager Instance;
    public GameObject WizardPrefab;

    public GameObject PauseAC;

    void Awake()
    {


        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            Score = 0;
        }
        else {
            Destroy(gameObject);
        
        }
        


        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (GMstate.Equals("Game")) {
           Timer = Timer - (Time.deltaTime * 1);

           if (Timer <= 0)
            {
                SceneManager.LoadScene("GameManager");
                GMstate = "Menü";
                Timer = 180f;
            }

            
        }



        if (Input.GetKeyDown(KeyCode.Escape)) {

            if (PauseAC.activeSelf) {
                PauseAC.SetActive(false);
                Time.timeScale = 1;
                Wizard.PauseA = false;
            }
            else {

                PauseAC.SetActive(true);
                Time.timeScale = 0;
                Wizard.PauseA = true;
            }



        }

        if (GMstate.Equals("Destroyed")) {
            SceneManager.LoadScene("GameOver");
            GMstate = "GameOverDone";
        }


    }


    public void OnClickStart() {
        SceneManager.LoadScene("Intruduction");
        GMstate = "Game";
    }

    public void OnClickNewGame() {
        
        
        GMstate = "Game";
        Wizard.stats = new PlayerStats();
        Score = 0;
        SceneManager.LoadScene("Intruduction");

        Wizard.PauseA = false;
        Time.timeScale = 1f;
    }

   

    public void OnClickBeenden() { 
       Application.Quit();
    }

   

}
