using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleButton : MonoBehaviour
{

    
    public void ClickonStart()
    {
         GameManager.Instance.OnClickStart(); 
        
    }

    public void ClickonNewGame()
    {
        GameManager.Instance.OnClickNewGame();
       
    }
    public void ClickonExit()
    {
        GameManager.Instance.OnClickBeenden();
    }
}
