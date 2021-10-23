using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public Scene currentScene;
    public static int currentIndex = 0;

    // Update is called once per frame
    public static void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene($"Map_{currentIndex}", LoadSceneMode.Additive);

    }

    public void Play(int index)
    {
        currentIndex = index;
        SceneManager.LoadScene("MainScene");
        SceneManager.LoadScene($"Map_{index}", LoadSceneMode.Additive);
    }

    //load map
    public static void LoadNextMap()
    {
        SceneManager.LoadScene("MainScene");
        SceneManager.LoadScene($"Map_{currentIndex++}", LoadSceneMode.Additive);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("GameMenu");
    }
}
