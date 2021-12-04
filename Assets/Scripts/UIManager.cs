using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager ins;
    public static bool gameIsPause = false;

    public GameObject pauseMenu;
    public GameObject uiWinGame;

    public static int scoreValue = 0;
    Text score;

    

    private void Awake()
    {
        makeSingleton();
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
                Debug.Log("Game is pause");
            }
        }



    }//update

    //continue game
    public void Resume()
    {
        FindObjectOfType<AudioManager>().Play("button");
        PauseSetActive(false);
        Time.timeScale = 1f;
        gameIsPause = false;
    }

    //pause scene , stop action game
    public void Pause()
    {
        FindObjectOfType<AudioManager>().Play("button");
        PauseSetActive(true);
        uiWinGame.SetActive(false);
        Time.timeScale = 0f;
        gameIsPause = true;
        Debug.Log("Called");
    }

    //replay game, replay action game
    public void ReplayPauseScene()
    {
        FindObjectOfType<AudioManager>().Play("button");
        PauseSetActive(false);
        Time.timeScale = 1f;
        gameIsPause = false;
        GameManagement.Replay();
    }

    void PauseSetActive(bool isActive)
    {
        pauseMenu.SetActive(isActive);
    }

    public void SetGameIsPause(bool isPause)
    {
        gameIsPause = isPause;
        Time.timeScale = 1f;
    }

    void makeSingleton()
    {
        if( ins == null)
        {
            ins = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    
}
