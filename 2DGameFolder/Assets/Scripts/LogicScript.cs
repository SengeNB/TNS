using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject tutorialEndScreen;
    public GameObject victoryEndScreen;
    public GameObject pauseMenu;
    public BelugaScript beluga;
    public static bool isPaused;

    private void Start()
    {
        pauseMenu.SetActive(false);
        beluga = GameObject.FindGameObjectWithTag("Player").GetComponent<BelugaScript>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            } 
            
            else
            {
                PauseGame();
            }
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void TutorialEnd()
    {
        tutorialEndScreen.SetActive(true);
        beluga.IncreaseSpeed();
    }

    public void Cutscene2Plays()
    {
        SceneManager.LoadSceneAsync("Cutscene 2");
    }

    public void Cutscene1End()
    {
        SceneManager.LoadSceneAsync("Game");
    }

    public void Cutscene2End()
    {
        SceneManager.LoadSceneAsync("Credits");
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }

    public void QuitGameAgain()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
