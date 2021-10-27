using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusPoint : MonoBehaviour
{
    public GameObject heart;
    //carController Class
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //UIManager.scoreValue += 10;
            CarController.heart = 1f;
            Destroy(gameObject);
        }
    }
}
