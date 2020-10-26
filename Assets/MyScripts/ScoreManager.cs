/*
 *  ScoreManager.cs Script
    Nicolas Plumb / 101078622 / October 23 2020
    
    ChangeScore
    Updates the players score on the UI
    SaveScore
    saves the score for scene changing
    
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    [Header("Player Score")]
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    public static int score;
    Scene scene = SceneManager.GetActiveScene();
    Text txt;
    
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
        if (instance == null)
        {
            instance = this;
        }
        //DontDestroyOnLoad(gameObject);
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "" + score.ToString();
    }

    void SaveScore()
    {
        PlayerPrefs.SetInt("Score", score);

        
    }



}
