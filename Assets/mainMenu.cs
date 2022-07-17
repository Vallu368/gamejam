using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void SetFullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }
}
