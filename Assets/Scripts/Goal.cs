using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    public GameObject guiWinGame;

    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            guiWinGame.SetActive(true);
            //StartCoroutine(SetActive());
            yield return new WaitForSeconds(2);
            GameManagement.currentIndex++;
            Debug.Log(GameManagement.currentIndex);
            GameManagement.LoadNextMap();
        }
        //StartCoroutine(SetActive());
    }

    //IEnumerator SetActive()
    //{
    //    guiWinGame.SetActive(true);
    //    yield return new WaitForSeconds(10);
        
    //}




}
