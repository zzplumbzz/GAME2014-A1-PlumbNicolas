/*
 *  RestartButton.cs Script
    Nicolas Plumb / 101078622 / October 23 2020
    
    OnRestartPressed
    Transitions from main Game over scene to the game scene by button press
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
   
    public void OnRestartPressed()
    {
        Debug.Log("RestartButton Pressed");
        SceneManager.LoadScene("Game");
    }
}
