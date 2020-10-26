/*
 *  ButtonSound.cs Script
    Nicolas Plumb / 101078622 / October 23 2020
    
    PlaySound
    plays attatched sound clip 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonSound : MonoBehaviour
{
    [Header("Audio Clip")]
    public AudioClip sound;

    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;

        button.onClick.AddListener(() => PlaySound());
    }
    
    void PlaySound()
    {
        source.PlayOneShot(sound);
    }
    
}
