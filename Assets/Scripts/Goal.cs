using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    public GameObject guiWinGame;
    public static bool isWin = false;

    private void Awake()
    {
        isWin = false;
    }

    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            setGuiWinActive();
            //StartCoroutine(SetActive());
            yield return new WaitForSeconds(2);
            GameManagement.currentIndex++;
            GameManagement.LoadNextMap();
        }
        //StartCoroutine(SetActive());
    }


    //set GuiWinActive
    void setGuiWinActive()
    {
        guiWinGame.SetActive(true);
        isWin = true;
    }




}
