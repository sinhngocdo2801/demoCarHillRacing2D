using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPause = false;

    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (gameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    //continue game
    public void Resume()
    {
        PauseSetActive(false);
        Time.timeScale = 1f;
        gameIsPause = false;
    }

    //pause scene , stop action game
    public void Pause()
    {
        PauseSetActive(true);
        //Goal.guiWinGame.SetActive(false);
        Time.timeScale = 0f;
        gameIsPause = true;
    }

    //replay game, replay action game
    public void ReplayPauseScene()
    { 
        PauseSetActive(false);
        Time.timeScale = 1f;
        GameManagement.Replay();
    }

    void PauseSetActive(bool isActive)
    {
        pauseMenu.SetActive(isActive);
    }

}
