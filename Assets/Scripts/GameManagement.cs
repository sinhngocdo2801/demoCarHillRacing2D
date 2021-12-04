using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public static GameManagement Intance;

    public static int currentIndex = 0;

    //Var slider sound
    public GameObject slider;

    bool isClicked = false;

    //public static int isLastScene = 0;

    private void Awake()
    {

        MakeSingleton();
    }
    // Update is called once per frame


    public void Play(int index)
    {
        FindObjectOfType<AudioManager>().Play("button");
        SceneManager.LoadScene("MainScene");
        SceneManager.LoadScene($"Map_{index}", LoadSceneMode.Additive);
        currentIndex = index;
    }

    public static void Replay()
    {
        FindObjectOfType<AudioManager>().Play("button");
        UIManager.ins.SetGameIsPause(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene($"Map_{currentIndex}", LoadSceneMode.Additive);
        //SceneManager.LoadScene("Map_1", LoadSceneMode.Additive);

    }

    //load map
    public static void LoadNextMap()
    {
        FindObjectOfType<AudioManager>().Play("button");
        currentIndex++;
        if (currentIndex == 6)
        {
            SceneManager.LoadScene("LastScene");
        }
        else
        {
            SceneManager.LoadScene("MainScene");
            SceneManager.LoadScene($"Map_{currentIndex}", LoadSceneMode.Additive);
        }
        
    }

    public void QuitGame()
    {
        FindObjectOfType<AudioManager>().Play("button");
        Application.Quit();
    }

    public void Menu()
    {
        FindObjectOfType<AudioManager>().Play("button");
        UIManager.gameIsPause = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameMenu");
    }


    //working with button sound
    public void WhenButtonClicked()
    {
        FindObjectOfType<AudioManager>().Play("button");
        if (slider.activeInHierarchy == true)
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





    public void MakeSingleton()
    {
        if(Intance == null)
        {
            Intance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


}
