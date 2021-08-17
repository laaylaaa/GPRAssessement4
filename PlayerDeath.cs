// Layla Darwiche 
// GPR103 
// Assessment 4 - Game Project
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

// -------- PLAYERS DEATH AND DEATH COUNT --------
// Had from another project! Added a few features 
// Manages the player dying as well as keeping track in a count

public class PlayerDeath : MonoBehaviour
{

    [SerializeField] Transform Respawn; // transform for respawning
    // Respawn 2 is only used for Level 5 Hard where player can die inside the area where they are timed
    // made a new respawn almost like a check point for them 
    [SerializeField] Transform Respawn2; 

    public GameObject Player; // get player 

    // Hold the audio for the death sound 
    public AudioSource deathSound; 

    // Death count variables 
    public Text deathCount;
    private int count; 

    // when game starts set count to 0 and set the count text to display on screen, check the death count to make sure each level starts at 0 
    // collect the death sound audio source so it can be played when they die 
    private void Start()
    {
        count = 0; 
        SetCountText();
        CheckDeathCount();
        deathSound = GetComponent<AudioSource>(); // gets the AudioSource which is on Player
    }

    // if player collides with the walls tagged with "Kill" or "Kill2" then change there position, play death sound and add one to count, update the count text
     private void OnCollisionEnter2D(Collision2D collision)  
    {
        if (collision.transform.CompareTag("Kill"))
        {
            Player.transform.position = Respawn.position; // change players position to the respawns position 
            deathSound.Play(); // play the death sound when they die 
            count = count + 1; // adding one to the count
            SetCountText();
        }else if (collision.transform.CompareTag("Kill2"))
        {
            // used in Level 5 
            Player.transform.position = Respawn2.position;
            deathSound.Play(); // play the death sound when they die 
            count = count + 1; // adding one to the count
            SetCountText();
        }

    }

    // sets the text for the count 
    void SetCountText()
    {
        deathCount.text = "Deaths: " + count.ToString(); // setting the text 
    }

    // ensures that count starts at 0 
    void CheckDeathCount()
    {
        if (Application.isPlaying)
        {
            count = 0; 
        }
    }
}
