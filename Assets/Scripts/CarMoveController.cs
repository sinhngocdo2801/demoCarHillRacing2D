using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CarMoveController : MonoBehaviour
{
    public static bool isUpButtonDown ;
    public static bool isDownButtonDown ;
    public static bool isRightButtonDown ;
    public static bool isLeftButtonDown ;

    private void Start()
    {
        isUpButtonDown = false;
        isDownButtonDown = false;
        isRightButtonDown = false;
        isLeftButtonDown = false;
    }

    public void UpButtonDown()
    {
        isUpButtonDown = true;
        Debug.Log("press down" + isUpButtonDown);
    }
    public void UpButtonUp()
    {
        isUpButtonDown = false;
        Debug.Log("press not down" + isUpButtonDown);
    }
    public void DownButtonDown()
    {
        isDownButtonDown = true;
        Debug.Log("press down");
    }
    public void DownButtonUp()
    {
        isDownButtonDown = false;
        Debug.Log("press not down");
    }
    public void RightButtonDown()
    {
        isRightButtonDown = true;
        Debug.Log("press down");
    }
    public void RightButtonUp()
    {
        isRightButtonDown = false;
        Debug.Log("press not down");
    }
    public void LeftButtonDown()
    {
        isLeftButtonDown = true;
        Debug.Log("press down");
    }
    public void LeftButtonUp()
    {
        isLeftButtonDown = false;
        Debug.Log("press not down");
    }


}
