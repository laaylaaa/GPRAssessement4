// Layla Darwiche 
// GPR103 
// Assessment 4 - Game Project
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

// -------- VOLUME CHANGING FOR PAUSE BUTTON ----------
// Had this from previous project
// helps with pausing the music 

public class VolumeChange : MonoBehaviour
{
    // button original image state
    public Image soundButton;
    // sprite for when music is on
    public Sprite musicOnSprite;
    // sprite for when msuic is off
    public Sprite musicOffSprite;
    // Reference for the SoundManager script in the scene 
    private SoundManager sound;

    // Start is called before the first frame update
    void Start()
    {
        // get the sound manager script
        sound = FindObjectOfType<SoundManager>();
        // checks sound and decides which image has to be displayed
        if (PlayerPrefs.HasKey("Sound"))
        {
            if (PlayerPrefs.GetInt("Sound") == 0)
            {
                soundButton.sprite = musicOffSprite;
            }
            else
            {
                soundButton.sprite = musicOnSprite;
            }
        }
        else
        {
            soundButton.sprite = musicOnSprite;
        }
    }

    // for the onClick() on the sound button
    public void SoundButton()
    {
        // if they click it and sound is off turn sound on and change the sprite
        // if they click it and sound is on turn sound off and change the sprite
        if (PlayerPrefs.HasKey("Sound"))
        {
            if (PlayerPrefs.GetInt("Sound") == 0)
            {
                soundButton.sprite = musicOnSprite;
                PlayerPrefs.SetInt("Sound", 1);
                sound.AdjustVolume();
            }
            else
            {
                soundButton.sprite = musicOffSprite;
                PlayerPrefs.SetInt("Sound", 0);
                sound.AdjustVolume();

            }
        }
        else
        {
            soundButton.sprite = musicOffSprite;
            PlayerPrefs.SetInt("Sound", 1);
            sound.AdjustVolume();


        }
    }
}
