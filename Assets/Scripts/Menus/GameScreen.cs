using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScreen : Menu
{
    PuzzleGrid puzzleGrid;
    private void Start()
    {
        // Whenever a button is clicked, we run this function
        puzzleGrid = GetComponentInChildren<PuzzleGrid>();
        puzzleGrid.OnButtonClicked += OnButtonClicked;
    }

    public override void OpenMenu()
    {
        base.OpenMenu();
        Cursor.lockState = CursorLockMode.None;
    }

    public override void CloseMenu()
    {
        base.CloseMenu();
        Cursor.lockState = CursorLockMode.None;
    }

    public void OnButtonClicked()
    {
        if (puzzleGrid.CheckForWinner())
        {
            Debug.Log("win");
            puzzleGrid.Freeze();
        }
    }
}