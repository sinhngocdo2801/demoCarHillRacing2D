using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    public GameObject guiWinGame;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            guiWinGame.SetActive(true);
            GameManagement.LoadNextMap();
        }
    }




}
