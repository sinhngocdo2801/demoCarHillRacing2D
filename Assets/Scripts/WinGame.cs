using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{


    //var for GUIWIN
    public static bool isWin = false;
    public GameObject guiWinGame;

    private void Awake()
    {
        isWin = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Goal")
        {
            setGuiWinActive();
        }
    }

    //set GuiWinActive
    public void setGuiWinActive()
    {
        guiWinGame.SetActive(true);
        isWin = true;
    }
}
