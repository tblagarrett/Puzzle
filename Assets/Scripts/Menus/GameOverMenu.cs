using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : Menu
{
    public override void OpenMenu()
    {
        base.OpenMenu();
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("Game Over Menu Opened");
    }

    public override void CloseMenu()
    {
        base.CloseMenu();
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("Game Over Menu Closed");
    }
}