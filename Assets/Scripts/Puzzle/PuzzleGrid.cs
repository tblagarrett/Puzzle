using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleGrid : MonoBehaviour
{
    private PuzzleSwitch[] puzzleSwitches;
    public delegate void functionIfWin();

    public delegate void ButtonClickHandler();
    public event ButtonClickHandler OnButtonClicked;

    // Start is called before the first frame update
    void Start()
    {
        // instatiate array of switches
        puzzleSwitches = GetComponentsInChildren<PuzzleSwitch>(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        // Get all PuzzleSwitch components from children buttons
        PuzzleSwitch[] puzzleSwitches = GetComponentsInChildren<PuzzleSwitch>();

        // Subscribe to the event for each PuzzleSwitch
        foreach (PuzzleSwitch puzzleSwitch in puzzleSwitches)
        {
            puzzleSwitch.ButtonClick += ButtonClicked;
        }
    }

    // Got help from chatgpt with this: "how do i make a function accept a lambda as a parameter, and make it optional"
    public bool checkForWinner(functionIfWin lambda = null)
    {
        foreach (PuzzleSwitch sw in puzzleSwitches)
        {
            if (sw.state == PuzzleSwitchState.off)
            {
                return false;
            }
        }

        // Check if a lambda is provided before invoking it
        lambda?.Invoke();

        return true;
    }

    public void ButtonClicked()
    {
        if (OnButtonClicked != null) { OnButtonClicked(); }
    }
}
