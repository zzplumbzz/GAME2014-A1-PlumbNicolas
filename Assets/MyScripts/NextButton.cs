/*
 *  NextButton.cs Script
    Nicolas Plumb / 101078622 / October 23 2020
    
    OnNextButtonPressed
    Transitions from main Game scene to the game over scene by button press (For testing puposes but not used now)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButton : MonoBehaviour
{
    
    public void OnNextButtonPressed()
    {
        Debug.Log("NextButton Pressed");
        SceneManager.LoadScene("GameOver");
    }
}
