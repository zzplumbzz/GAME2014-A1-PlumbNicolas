/*
 *  HowToPlayButton.cs Script
    Nicolas Plumb / 101078622 / October 23 2020
    
    OnHowToPlayButtonPressed
    Transitions from main menu scene to the how to play scene by button press
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayButton : MonoBehaviour
{
    
    public void OnHowToPlayButtonPressed()
    {
        Debug.Log("OnHowToPlayButton Pressed");
        SceneManager.LoadScene("HowToPlay");
    }
}
