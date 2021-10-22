using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManage : MonoBehaviour
{
    public  GameObject txt;
    private string text;

    private string[] gameOver = { "this game is very easy", "hard game?", "haven't won yet?", "Gameover"};
    // Update is called once per frame
    

    void Update()   
    {
        if(EndGame.isGameover == true && EndGame.isActive == true)
        {
            RandomText();
            EndGame.isActive = false;
        }
        
        
    }

    void RandomText()
    {
        txt.GetComponent<UnityEngine.UI.Text>().text = gameOver[Random.Range(0, gameOver.Length)];
    }
}
