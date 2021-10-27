using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    Scene scene;
    public static int currentIndex;

    public GameObject slider;

    bool isClicked = false;

    public static int isLastScene = 0;

    private void Awake()
    {
        if (currentIndex > 1)
        {
            //currentIndex = SceneManager.GetActiveScene().buildIndex + 1;
            currentIndex = currentIndex;
        }
        else
        {
            currentIndex = 1;
        }
        //currentIndex = 1;
    }
    // Update is called once per frame
    public static void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //SceneManager.LoadScene($"Map_{currentIndex}", LoadSceneMode.Additive);
        SceneManager.LoadScene("Map_1", LoadSceneMode.Additive);

    }

    public void Play(int index)
    {
        FindObjectOfType<AudioManager>().Play("button");
        //currentIndex = index;
        SceneManager.LoadScene("MainScene");
        SceneManager.LoadScene($"Map_{index}", LoadSceneMode.Additive);
    }

    //load map
    public static void LoadNextMap()
    {
        //currentIndex++;
        SceneManager.LoadScene("MainScene");
        SceneManager.LoadScene($"Map_{currentIndex}", LoadSceneMode.Additive);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Menu()
    {
        UIManager.gameIsPause = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameMenu");
    }


    //working with button sound
    public void WhenButtonClicked()
    {
        if(slider.activeInHierarchy == true)
        {
            slider.SetActive(false);
        }
        else
        {
            slider.SetActive(true);
        }
    }

    public void OnSetting()
    {
        if(isClicked == true)
        {
            slider.SetActive(true);
        }
        else
        {
            isClicked = false;
        }
    }
}
