using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScreen : Menu
{
    public override void OpenMenu()
    {
        base.OpenMenu();
        Cursor.lockState = CursorLockMode.Locked;
        Debug.Log("Options Menu Opened");
    }

    public override void CloseMenu()
    {
        base.CloseMenu();
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("Options Menu Closed");
    }
}