using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScreen : UIScreen
{
    [SerializeField] private Button back;

    [SerializeField] private UIScreen menuScreen;

    public override void SetupScreen(UIScreen previousScreen)
    {
        if (menuScreen == null)
            menuScreen = previousScreen;

        back.AddListener(LeavingOptions);
    }

    void LeavingOptions()
    {
        CloseScreen();
        menuScreen.StartScreen();
    }
}