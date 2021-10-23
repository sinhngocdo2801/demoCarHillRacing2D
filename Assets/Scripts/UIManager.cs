using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static bool gameIsPause = false;

    public GameObject pauseMenu;
    public GameObject uiWinGame;

    public static int scoreValue = 0;
    Text score;

    private void Awake()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // pause game
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

        //update score
        //score.text = "SCORE: " + scoreValue.ToString();
        //---



    }//update

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
        uiWinGame.SetActive(false);
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
