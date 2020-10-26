/*
 *  HealthBarScript.cs Script
    Nicolas Plumb / 101078622 / October 23 2020
    
    SetMaxHealth
    Sets the players max health on the health bar
    SetHealth
    controls the players health represented on the health bar 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    [Header("Player Health Bar Slider")]
    public Slider slider;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
