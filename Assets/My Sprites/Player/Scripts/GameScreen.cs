using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScreen : UIScreen
{
    [SerializeField] private Button back;

    [SerializeField] private UIScreen menuScreen;

    public override void SetupScreen(UIScreen previousScreen)
    {
        if (menuScreen == null)
            menuScreen = previousScreen;

        back.AddListener(BackToMenu);
    }

    void BackToMenu()
    {
        CloseScreen();
        menuScreen.StartScreen();
    }
}
