using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {
    //public static EndGame ins;
    public GameObject gameoverUI;
    public static bool isGameover = false;
    public static bool isActive = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collidable"))
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        if (WinGame.isWin == false)
        {
            gameoverUI.SetActive(true);
            isGameover = true;
            isActive = true;
            Debug.Log("caleld");
        }
    }

    //void makeSingleton()
    //{
    //    if(ins == null)
    //    {
    //        ins = this;
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    }
    //}



}
