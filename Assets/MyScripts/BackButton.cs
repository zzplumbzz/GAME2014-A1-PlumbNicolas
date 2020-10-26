/*
 *  BackButton.cs Script
    Nicolas Plumb / 101078622 / October 23 2020
    
    OnBackButtonPressed
    Transitions from how to play scene and game over scene to the menu scene by button press
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
   
    public void OnBackButtonPressed()
    {
        Debug.Log("BackButton Pressed");
        SceneManager.LoadScene("Menu");
    }
}
