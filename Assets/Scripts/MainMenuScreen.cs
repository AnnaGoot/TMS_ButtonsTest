using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScreen : UIScreen
{
    [SerializeField] private Button startGame, options, shop;
    [SerializeField] private UIScreen gameScreen;
    [SerializeField] private UIScreen optionsScreen;
    [SerializeField] private UIScreen shopScreen;

    public int gameSceneIndex = 0;


    public override void SetupScreen(UIScreen previousScreen)
    {
        Debug.Log("Nothing to setup");
    }

    public override void StartScreen()
    {
        base.StartScreen();

        startGame.AddListener(OpenGame);
        options.AddListener(OpenOptions);
        shop.AddListener(OpenShop);
    }

    void OpenGame()
    {
        Debug.Log("Game start");

        gameSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadSceneAsync(gameSceneIndex);

        //gameScreen.SetupScreen(this);
        //CloseScreen();
        //gameScreen.StartScreen();
    }

    void OpenOptions()
    {
        Debug.Log("Options menu is open");

        optionsScreen.SetupScreen(this);
        CloseScreen();

        optionsScreen.StartScreen();
    }

    void OpenShop()
    {
        Debug.Log("Shop is open");

        shopScreen.SetupScreen(this);
        CloseScreen();

        shopScreen.StartScreen();
    }


}