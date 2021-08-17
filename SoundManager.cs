// Layla Darwiche 
// GPR103 
// Assessment 4 - Game Project
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// --------- SOUND MANAGER FOR LEVELS ----------
// Had this script from previous projects 
// Used to hold the music for the level and helps with pause button

public class SoundManager : MonoBehaviour
{
    // audio sources for the game 
    public AudioSource[] destroyNoise;
    public AudioSource backgroundMusic; 

    private void Start()
    {
        // checks the sound and plays it when needed
        if (PlayerPrefs.HasKey("Sound"))
        {
            if (PlayerPrefs.GetInt("Sound") == 0)
            {
                backgroundMusic.Play();
                backgroundMusic.volume = 0;
            }
            else
            {
                backgroundMusic.Play();
                backgroundMusic.volume = 1;
            }
        }
        else
        {
            backgroundMusic.Play();
            backgroundMusic.volume = 1;
        }
       
    }

    // used for the pause button 
    public void AdjustVolume()
    {
        if (PlayerPrefs.HasKey("Sound"))
        {
            if (PlayerPrefs.GetInt("Sound") == 0)
            {
                backgroundMusic.volume = 0;
            }
            else
            {
                backgroundMusic.volume = 1;
            }
        }
      
    }
}
