using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour
{

   

    public void ClickonBackToMain()
    {

        SceneManager.LoadScene("GameManager");
    }
    public void ClickonExit()
    {
        GameManager.Instance.OnClickBeenden();
    }
}
