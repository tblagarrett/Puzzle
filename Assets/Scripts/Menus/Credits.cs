using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : Menu
{
    public override void OpenMenu()
    {
        base.OpenMenu();
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("Credits Menu Opened");
    }

    public override void CloseMenu()
    {
        base.CloseMenu();
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("Credits Menu Closed");
    }
}
