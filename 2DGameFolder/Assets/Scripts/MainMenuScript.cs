using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    //Loads the Scene where the main game takes place
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Cutscene 1");
    }

    //Loads the Scene where the tutorial takes place
    public void PlayTutorial()
    {
        SceneManager.LoadSceneAsync("Tutorial");
    }

    //Shuts down the application/game
    public void QuitGame()
    {
        Application.Quit();
    }
}
