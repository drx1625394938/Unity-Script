using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    //��ʼ��Ϸ
    public void StartGame() 
    {
        SceneManager.LoadScene("Loading");
    }

    public void ExitGame() 
    {
        Application.Quit();
    }



    

    
}
