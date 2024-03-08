using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MenuSwitch : MonoBehaviour
{

    public void LoadScreen(int Game)
    {
        SceneManager.LoadScene(Game);
    }

    public void Exit()
    {
        Application.Quit();
    
    }

}
