using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnHowToPlayButtonPressed()
    {
        Debug.Log("OnHowToPlayButton Pressed");
        SceneManager.LoadScene("HowToPlay");
    }
}
