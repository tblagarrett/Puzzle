using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScreen : Menu
{
    public override void OpenMenu()
    {
        base.OpenMenu();
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("Game Menu Opened");
    }

    public override void CloseMenu()
    {
        base.CloseMenu();
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("Game Menu Closed");
    }
}