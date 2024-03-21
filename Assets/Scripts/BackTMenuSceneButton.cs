using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackTMenuSceneButton : MenuButton
{

    void Start()
    {
        onClick = () => SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
