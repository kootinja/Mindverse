using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject escapeMenu;
    public GameObject optionsMenu;
    public GameObject pauseMenu;
    public static bool GameIsPaused = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
            escapeMenu.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
    }

    public void Pause()
    {

            escapeMenu.SetActive(true);
        if (optionsMenu.activeInHierarchy)
        {
            optionsMenu.SetActive(false);
            pauseMenu.SetActive(true);
        }
            Time.timeScale = 0f;
            GameIsPaused = true;
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
