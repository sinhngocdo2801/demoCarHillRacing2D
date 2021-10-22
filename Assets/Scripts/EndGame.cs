using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {
    public GameObject gameoverUI;
    public static bool isGameover = false;
    public static bool isActive = false;

    void OnTriggerEnter2D(Collider2D colInfo)
    {
        if (colInfo.CompareTag("Collidable"))
        {
            gameoverUI.SetActive(true);
            isGameover = true;
            isActive = true;
        }
    }



}
