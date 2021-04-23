using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    public void QuitApp()
    {
        Debug.Log("Application exited !!");
        Application.Quit();
    }
}
