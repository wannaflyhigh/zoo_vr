using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuExit : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log(" Exit!! ");
        Application.Quit();
    }
}