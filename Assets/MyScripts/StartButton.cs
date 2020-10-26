/*
 *  StartButton.cs Script
    Nicolas Plumb / 101078622 / October 23 2020
    
    OnStartButtonPressed
    Transitions from main menu to the game scene by button press
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    
    public void OnStartButtonPressed()
    {
        Debug.Log("StartButton Pressed");
        SceneManager.LoadScene("Game");
    }
}
